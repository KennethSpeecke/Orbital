using System;

namespace Imi.Project.Mobile.ViewModels.SpaceObjects
{
    public class PlanetoidItemViewModel : SpaceBaseItemViewModel<Guid>
    {
        #region Fields

        private string composition;
        private string discoverername;
        private string shape;

        #endregion Fields

        #region Properties

        public string Composition

        {
            get { return composition; }
            set { composition = value; }
        }

        public string DiscovererName
        {
            get { return discoverername; }
            set { discoverername = value; }
        }

        public string Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        #endregion Properties
    }
}