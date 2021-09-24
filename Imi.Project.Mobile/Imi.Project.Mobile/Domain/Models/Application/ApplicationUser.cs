using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace Imi.Project.Mobile.Domain.Models.Application
{
    public class ApplicationUser
    {
        #region Properties

        public string Email { get; set; }
        public Location GeoLocation { get; set; }
        public string HashedPassword { get; set; }
        public Guid Id { get; set; }
        public bool RecieveNotifications { get; set; }
        public IEnumerable<UserComment> UserComments { get; set; }
        public ICollection<SpaceBaseItemViewModel<Guid>> UserFavorites { get; set; }
        public string UserName { get; set; }

        #endregion Properties
    }
}