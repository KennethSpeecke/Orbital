using Imi.Project.Mobile.Domain.Models.Base;
using System;

namespace Imi.Project.Mobile.Domain.Models.SpaceObjects
{
    public class DebrisModel : BaseSpaceItemModel<Guid>
    {
        #region Properties

        public bool IsOnCollisionCourse { get; set; }

        #endregion Properties
    }
}