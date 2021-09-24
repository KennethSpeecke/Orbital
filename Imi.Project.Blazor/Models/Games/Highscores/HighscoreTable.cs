using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Models.Games.Highscores
{
    public class HighscoreTable<T> where T : HighscoreEntry
    {
        #region Properties

        public ICollection<T> Entries { get; set; }
        public Guid Id { get; set; }

        #endregion Properties
    }
}