using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IApplicationUserService<T, TKey> where T : ApplicationUser
    {
        #region Methods

        Task<IEnumerable<ApplicationUser>> GetAll();

        Task<ApplicationUser> GetUserByEmail(string email);

        Task<ApplicationUser> GetUserById(TKey id);

        Task<IEnumerable<UserComment>> GetUsersComments(T user);

        Task<IEnumerable<SpaceBaseItemViewModel<TKey>>> GetUsersFavorites(T user);

        Task<bool> LoginUser(T userToLogin, string password);

        Task<bool> LogoutUser(T userToLogout);

        Task<bool> RegisterUser(T userToRegister);

        Task<bool> UpdateUserPassword(T user, string newPassword);

        Task<bool> UpdateUserProfile(T user);

        #endregion Methods
    }
}