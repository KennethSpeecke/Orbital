using System;

namespace Imi.Project.Mobile.ViewModels.SpaceObjects
{
    public class DebrisItemViewModel : SpaceBaseItemViewModel<Guid>
    {
        #region Fields

        private string isOnCollisionCourse;

        #endregion Fields

        #region Properties

        public string IsOnCollisionCourse
        {
            get { return isOnCollisionCourse; }
            set { isOnCollisionCourse = value; }
        }

        #endregion Properties
    }
}