using Imi.Project.Blazor.Models.Application;
using Imi.Project.Blazor.Models.Games.Base;
using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts
{
    public class Game : PlanetoidsDebrisCraftsBase<Guid>
    {
        #region Properties

        public string ComputerImage { get; set; }
        public string ComputerName { get; set; }
        public int ComputerScore { get; set; }
        public ICollection<GameRule> GameRules { get; set; }
        public ApplicationUser Player { get; set; }
        public int PlayerScore { get; set; }
        public string StateMessage { get; set; }

        #endregion Properties
    }
}