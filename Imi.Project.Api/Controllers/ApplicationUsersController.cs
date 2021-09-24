using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ObjectsTracking;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Authorize(Roles = "admin")]
    [ApiController]
    [Route("api/auth")]
    public class ApplicationUsersController : ControllerBase
    {
        #region Fields

        private readonly IAuthenticationService<ApplicationUser> _authenticationService;
        private readonly ISpaceObjectLocationService _spaceObjectLocationService;
        private readonly IUserService _userService;

        #endregion Fields

        #region Constructors

        public ApplicationUsersController(
            IUserService userService,
            ISpaceObjectLocationService spaceObjectLocationService,
            IAuthenticationService<ApplicationUser> authenticationService)
        {
            _userService = userService;
            _spaceObjectLocationService = spaceObjectLocationService;
            _authenticationService = authenticationService;
        }

        #endregion Constructors

        #region Methods

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var applicationUsers = await _userService.ListAllAsync();
                return Ok(applicationUsers);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] ApplicationUserLoginRequestDto applicationUserLoginRequestDto)
        {
            var result = await _authenticationService.Authenticate(applicationUserLoginRequestDto);
            if (result.HasErrors)
            {
                foreach (var error in result.ErrorMessages)
                {
                    ModelState.AddModelError("Invalid authentication parameters", error);
                }
                return BadRequest(ModelState);
            }
            return Ok(new ApplicationUserLoginResponseDto()
            {
                ResponseToken = result.Token
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] ApplicationUserRegisterRequestDto applicationUserRequestDto)
        {
            var result = await _authenticationService.Register(applicationUserRequestDto);
            if (result.HasErrors)
            {
                foreach (var error in result.ErrorMessages)
                {
                    ModelState.AddModelError("", error);
                }
                return BadRequest(ModelState);
            }

            return Ok(result.SuccessMessage);
        }

        #endregion Methods
    }
}