using Imi.Project.Blazor.Models.Application;
using Imi.Project.Blazor.Models.Games.Base;
using Imi.Project.Blazor.Models.Games.Highscores;
using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using Imi.Project.Blazor.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.OrbitalApi
{
    public class GameService : IGameService<PlanetoidsDebrisCraftsBase<Guid>>
    {
        #region Methods

        public Task<bool> CheckGameRoundState(Selection playerSelection, Selection computerSelectoin, GameRule gameRule)
        {
            throw new NotImplementedException();
        }

        public Task<HighscoreEntry> EndGame(HighscoreTable<HighscoreEntry> highscoreTable)
        {
            throw new NotImplementedException();
        }

        public Task<Selection> GetComputerMove(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetPlayerData()
        {
            throw new NotImplementedException();
        }

        public Task<Selection> GetPlayerMove(ApplicationUser player)
        {
            throw new NotImplementedException();
        }

        public Task ResetGame(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<Selection> SetComputerMove(Selection selection)
        {
            throw new NotImplementedException();
        }

        public Task StartGame(ApplicationUser player, Game game)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}