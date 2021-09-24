using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockApplicationUserService : IApplicationUserService<ApplicationUser, Guid>
    {
        #region Temporary static test data until storage provider is ready...

        private static IEnumerable<ApplicationUser> userList = new List<ApplicationUser>
        {
            new ApplicationUser
            {
                Id = Guid.Parse("00000000-0000-1111-0000-000000000000"),
                Email = "Jhon.doe@mailinator.com",
                UserName = "Johnsky Doey",
                HashedPassword = "Test!123", //Just a test user REMOVE THIS WHEN DONE!
                RecieveNotifications = false,
                UserFavorites = new List<SpaceBaseItemViewModel<Guid>>(),
                UserComments = new List<UserComment>()
            },
            new ApplicationUser
            {
                Id = Guid.Parse("00000000-0000-2222-0000-000000000000"),
                Email = "Jane.doe@mailinator.com",
                UserName = "Janey Doey",
                HashedPassword = "JaneSky!123", //Just a test user REMOVE THIS WHEN DONE!
                RecieveNotifications = false,
                UserFavorites = new List<SpaceBaseItemViewModel<Guid>>(),
                UserComments = new List<UserComment>()
            }
        };

        private readonly ISpaceItemService<SpaceBaseItemViewModel<Guid>> _spaceItemRepository;
        private IEnumerable<SpaceBaseItemViewModel<Guid>> itemModels = new List<SpaceBaseItemViewModel<Guid>>();

        #endregion Temporary static test data until storage provider is ready...

        #region Constructors

        public MockApplicationUserService(ISpaceItemService<SpaceBaseItemViewModel<Guid>> spaceItemRepository)
        {
            _spaceItemRepository = spaceItemRepository;
        }

        #endregion Constructors

        #region Methods

        public async Task<IEnumerable<ApplicationUser>> GetAll()
        {
            await SetTestDataForFirstUser();
            return await Task.FromResult(userList);
        }

        public async Task<ApplicationUser> GetUserByEmail(string email)
        {
            return await Task.FromResult(userList.Where(u => u.Email == email).FirstOrDefault());
        }

        public Task<ApplicationUser> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<UserComment>> IApplicationUserService<ApplicationUser, Guid>.GetUsersComments(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpaceBaseItemViewModel<Guid>>> GetUsersFavorites(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginUser(ApplicationUser userToLogin, string password)
        {
            await SetTestDataForFirstUser();
            foreach (var user in userList)
            {
                if (user.UserName == userToLogin.UserName && user.HashedPassword == password)
                {
                    return await Task.FromResult(true);
                }
            }
            return await Task.FromResult(false);
        }

        public Task<bool> LogoutUser(ApplicationUser userToLogout)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterUser(ApplicationUser userToRegister)
        {
            throw new NotImplementedException();
        }

        public async Task SetTestDataForFirstUser()
        {
            itemModels = await _spaceItemRepository.GetAllAsync();
            foreach (var user in userList)
            {
                if (user.Id == Guid.Parse("00000000-0000-1111-0000-000000000000"))
                {
                    user.UserFavorites.Add(itemModels.FirstOrDefault());
                    user.UserComments.ToList().Add(new UserComment { ApplicationUser = user, Id = Guid.NewGuid(), Comment = "Truely Amazing!", SpaceItemModel = itemModels.FirstOrDefault() });
                }
            }
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