using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Entities.Base;
using System;

namespace Imi.Project.Api.Core.Entities
{
    public class FavoriteUserObject
    {
        #region Properties

        public BaseSpaceEntity SpaceObject { get; set; }
        public Guid SpaceObjectId { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        #endregion Properties
    }
}