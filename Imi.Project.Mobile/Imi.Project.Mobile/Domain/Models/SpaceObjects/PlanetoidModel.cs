using Imi.Project.Mobile.Domain.Models.Base;
using Imi.Project.Mobile.Domain.Models.Scientists;
using System;

namespace Imi.Project.Mobile.Domain.Models.SpaceObjects
{
    public class PlanetoidModel : BaseSpaceItemModel<Guid>
    {
        #region Properties

        public string Composition { get; set; }
        public AstronomerModel Discoverer { get; set; }
        public string Shape { get; set; }

        #endregion Properties
    }
}