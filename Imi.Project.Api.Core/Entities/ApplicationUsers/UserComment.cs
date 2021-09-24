using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Bases;
using System;

namespace Imi.Project.Api.Core.Entities.ApplicationUsers
{
    public class UserComment : BaseEntity<Guid>
    {
        #region Properties

        public Guid ApplicationUserId { get; set; }
        public bool IsDeleted { get; set; }
        public BaseSpaceEntity SpaceEntity { get; set; }
        public Guid SpaceEntityId { get; set; }
        public string Text { get; set; }

        #endregion Properties
    }
}