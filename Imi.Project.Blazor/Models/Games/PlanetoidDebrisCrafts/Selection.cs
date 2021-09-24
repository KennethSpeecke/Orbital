using Imi.Project.Blazor.Models.Games.Base;
using System;

namespace Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts
{
    public class Selection : PlanetoidsDebrisCraftsBase<Guid>
    {
        #region Properties

        public string Name { get; set; }
        public int Value { get; set; }

        #endregion Properties
    }
}