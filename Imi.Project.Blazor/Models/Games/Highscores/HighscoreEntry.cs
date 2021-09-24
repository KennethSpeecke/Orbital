using Imi.Project.Blazor.Models.Application;
using Imi.Project.Blazor.Models.Games.Base;
using System;

namespace Imi.Project.Blazor.Models.Games.Highscores
{
    public class HighscoreEntry : PlanetoidsDebrisCraftsBase<Guid>
    {
        #region Properties

        public ApplicationUser Player { get; set; }
        public int Score { get; set; }
        public string Title { get; set; }

        #endregion Properties
    }
}