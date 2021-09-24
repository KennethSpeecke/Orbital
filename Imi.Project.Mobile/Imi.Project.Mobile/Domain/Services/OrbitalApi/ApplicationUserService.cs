using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.OrbitalApi
{
    public class ApplicationUserService : IApplicationUserService<ApplicationUser, Guid>
    {
        #region Methods

        public Task<IEnumerable<ApplicationUser>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserComment>> GetUsersComments(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpaceBaseItemViewModel<Guid>>> GetUsersFavorites(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginUser(ApplicationUser userToLogin, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogoutUser(ApplicationUser userToLogout)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterUser(ApplicationUser userToRegister)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserPassword(ApplicationUser user, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserProfile(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}