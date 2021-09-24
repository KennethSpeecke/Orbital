using System;

namespace Imi.Project.Mobile.ViewModels.SpaceObjects
{
    public class SpaceCraftItemViewModel : SpaceBaseItemViewModel<Guid>
    {
        #region Fields

        private string missionInformation;

        #endregion Fields

        #region Properties

        public string MissionInformation
        {
            get { return missionInformation; }
            set { missionInformation = value; }
        }

        #endregion Properties
    }
}