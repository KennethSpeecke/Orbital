using Imi.Project.Api.Core.Entities.Base;

namespace Imi.Project.Api.Core.Entities.SpaceObjects
{
    public class SpaceDebrisEntity : BaseSpaceEntity
    {
        #region Properties

        public bool IsOnCollisionCourse { get; set; }

        #endregion Properties
    }
}