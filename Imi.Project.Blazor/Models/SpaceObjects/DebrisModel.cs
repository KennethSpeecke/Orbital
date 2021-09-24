using Imi.Project.Blazor.Models.Base;
using System;

namespace Imi.Project.Blazor.Models.SpaceObjects
{
    public class DebrisModel : BaseSpaceItem<Guid>
    {
        #region Properties

        public bool IsOnCollisionCourseWithEarth { get; set; }

        #endregion Properties
    }
}