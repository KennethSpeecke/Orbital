using Imi.Project.Api.Core.Entities.Base;
using System;

namespace Imi.Project.Api.Core.Entities.Bases
{
    public class BaseImageEntity : BaseEntity<Guid>
    {
        #region Properties

        public BaseSpaceEntity SpaceEntity { get; set; }
        public Guid SpaceEntityId { get; set; }
        public Uri Uri { get; set; }

        #endregion Properties
    }
}