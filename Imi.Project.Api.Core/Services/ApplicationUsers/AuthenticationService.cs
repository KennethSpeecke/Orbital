using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.ApplicationUsers
{
    public class AuthenticationService : IAuthenticationService<ApplicationUser>
    {
        #region Fields

        private readonly IConfiguration _configuration;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        #endregion Fields

        #region Constructors

        public AuthenticationService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        #endregion Constructors

        #region Methods

        public async Task<AuthenticationResult> Authenticate(ApplicationUserLoginRequestDto applicationUserLoginRequestDto)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(applicationUserLoginRequestDto.Username, applicationUserLoginRequestDto.Password, isPersistent: false, lockoutOnFailure: false);
                if (!result.Succeeded)
                {
                    return new AuthenticationResult() { HasErrors = true, SuccessMessage = "", ErrorMessages = new List<string>() { "Authentication has failed. Try again!" } };
                }

                var applicationUser = await _userManager.FindByNameAsync(applicationUserLoginRequestDto.Username);
                JwtSecurityToken token = await GenerateJsonWebTokenAsync(applicationUser);

                return new AuthenticationResult() { HasErrors = false, Token = new JwtSecurityTokenHandler().WriteToken(token), SuccessMessage = "Authentication success!" }; //serialize the token
            }
            catch
            {
                return new AuthenticationResult() { HasErrors = true, SuccessMessage = "", ErrorMessages = new List<string>() { "Unknown Error. If this keeps persisting. Contact a admin." } };
            }
        }

        public async Task<RegistrationResult> Register(ApplicationUserRegisterRequestDto applicationUserRequestDto)
        {
            try
            {
                ApplicationUser newUser = new ApplicationUser()
                {
                    Email = applicationUserRequestDto.Email,
                    Adress = applicationUserRequestDto.Adress,
                    Name = applicationUserRequestDto.Name,
                    Surname = applicationUserRequestDto.Surname,
                    BirthDate = applicationUserRequestDto.BirthDate,
                    UserName = applicationUserRequestDto.Username
                };

                IdentityResult result = await _userManager.CreateAsync(newUser, applicationUserRequestDto.Password);

                if (!result.Succeeded)
                {
                    var errorList = new List<string>();
                    foreach (var error in result.Errors)
                    {
                        errorList.Add(error.Description);
                    }
                    return new RegistrationResult() { HasErrors = true, SuccessMessage = "", ErrorMessages = errorList };
                }

                newUser = await _userManager.FindByEmailAsync(applicationUserRequestDto.Email);
                await _userManager.AddClaimAsync(newUser, new Claim("registration-date", DateTime.UtcNow.ToString("yy-MM-dd")));
                await _userManager.AddClaimAsync(newUser, new Claim("adress", applicationUserRequestDto.Adress));
                return new RegistrationResult() { HasErrors = false, SuccessMessage = "User registered!" };
            }
            catch
            {
                return new RegistrationResult() { HasErrors = true, SuccessMessage = "", ErrorMessages = new List<string>() { "Unknown error. Contact support." } };
            }
        }

        private async Task<JwtSecurityToken> GenerateJsonWebTokenAsync(ApplicationUser user)
        {
            var claims = new List<Claim>();

            // Loading the user Claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);

            // Loading the roles and put them in a claim of a Role ClaimType
            var roleClaims = await _userManager.GetRolesAsync(user);
            foreach (var roleClaim in roleClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleClaim));
            }
            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));

            var token = new JwtSecurityToken(
                            issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                            audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                            claims: claims,
                            expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                            notBefore: DateTime.UtcNow,
                            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey), SecurityAlgorithms.HmacSha256)
                            );
            return token;
        }

        #endregion Methods
    }
}