using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.ApplicationUsers
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        #region Methods

        public Task<ApplicationUser> GetUserByEmail(string userEmail);

        #endregion Methods
    }
}