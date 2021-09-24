using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Entities.Bases;
using Imi.Project.Api.Core.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class BaseSpaceEntity : BaseEntity<Guid>
    {
        #region Properties

        public int ApogeeInKm { get; set; }
        public ICollection<FavoriteUserObject> FavoriteUserObjects { get; set; }
        public ICollection<BaseImageEntity> Images { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public double Mass { get; set; }
        public string Name { get; set; }
        public int PerigeeInKm { get; set; }
        public string ShortName { get; set; }
        public double Size { get; set; }
        public SpaceObjectTypes SpaceObjectType { get; set; }
        public Uri ThumbnailImage { get; set; }
        public ICollection<UserComment> UserComments { get; set; }

        #endregion Properties
    }
}