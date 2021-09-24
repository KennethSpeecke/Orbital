using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers
{
    public interface IAuthenticationService<TUser> where TUser : ApplicationUser
    {
        #region Methods

        public Task<AuthenticationResult> Authenticate(ApplicationUserLoginRequestDto applicationUserLoginRequestDto);

        public Task<RegistrationResult> Register(ApplicationUserRegisterRequestDto applicationUserRequestDto);

        #endregion Methods
    }
}