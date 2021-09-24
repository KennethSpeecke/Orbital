using Imi.Project.Blazor.Models.Games.Base;
using System;

namespace Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts
{
    public class GameRule : PlanetoidsDebrisCraftsBase<Guid>
    {
        #region Properties

        public bool IsEnabled { get; set; }
        public bool IsRuleMet { get; set; }
        public string Title { get; set; }

        #endregion Properties
    }
}