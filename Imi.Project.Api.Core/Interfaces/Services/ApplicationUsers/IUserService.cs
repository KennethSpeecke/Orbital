using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers
{
    public interface IUserService : IService<ApplicationUserLoginResponseDto, ApplicationUserRegisterRequestDto>
    {
        #region Methods

        public Task<ApplicationUser> GetUserByEmail(string userEmail);

        #endregion Methods
    }
}