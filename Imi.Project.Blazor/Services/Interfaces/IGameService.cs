using Imi.Project.Blazor.Models.Application;
using Imi.Project.Blazor.Models.Games.Base;
using Imi.Project.Blazor.Models.Games.Highscores;
using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    internal interface IGameService<T> where T : PlanetoidsDebrisCraftsBase<Guid>
    {
        #region Methods

        public Task<bool> CheckGameRoundState(Selection playerSelection, Selection computerSelectoin, GameRule gameRule);

        public Task<HighscoreEntry> EndGame(HighscoreTable<HighscoreEntry> highscoreTable);

        public Task<Selection> GetComputerMove(Game game);

        public Task<ApplicationUser> GetPlayerData();

        public Task<Selection> GetPlayerMove(ApplicationUser player);

        public Task ResetGame(Game game);

        public Task<Selection> SetComputerMove(Selection selection);

        public Task StartGame(ApplicationUser player, Game game);

        #endregion Methods
    }
}