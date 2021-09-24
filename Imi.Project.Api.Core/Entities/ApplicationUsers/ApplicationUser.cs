using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.ApplicationUsers
{
    public class ApplicationUser : IdentityUser
    {
        #region Properties

        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<FavoriteUserObject> FavoriteUserObjects { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<UserComment> UserComments { get; set; }

        #endregion Properties
    }
}