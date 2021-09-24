using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Pages
{
    public partial class PdcGame
    {
        #region Fields

        private const int timeToWait = 3;
        private Random r = new Random();

        #endregion Fields

        #region Properties

        public Selection? BotSelection { get; set; }
        public Game Game { get; set; }
        public Selection? PlayerSelection { get; set; }
        public GameState State { get; set; } = GameState.MakeChoice;
        public int WinningPlayerId { get; set; }

        #endregion Properties

        #region Constructors

        public PdcGame()
        {
            Game = new Game()
            {
                StateMessage = "Loading up game...",
                GameRules = new List<GameRule>()
                {
                    new GameRule()
                    {
                        Id = Guid.NewGuid(),
                        Title = "Player beats Bot",
                        IsEnabled = true
                    },
                    new GameRule()
                    {
                        Id = Guid.NewGuid(),
                        Title = "Bot beats player",
                        IsEnabled = true
                    },
                },
                ComputerName = "DeepMind AI",
                ComputerImage = "default.jpg",
                ComputerScore = 0,
                PlayerScore = 0,
            };
        }

        #endregion Constructors

        #region Methods

        public async Task OnSelectionMadeClicked(Selection selection)
        {
            PlayerSelection = selection;
            var random = r.Next(0, 2);
            BotSelection = new Selection() { Value = random, Name = ((PossibleSelections)random).ToString(), Id = Guid.NewGuid() };

            State = GameState.WaitForResult;
            await Task.Delay(timeToWait * 800 - 200);

            //Calculate the winner now...
            CalculateWinner();
            State = GameState.ResultMet;
            //Set gamestate to Finished round...
        }

        public void StartNewGame()
        {
            State = GameState.MakeChoice;
            PlayerSelection = null;
            BotSelection = null;
        }

        private void CalculateWinner()
        {
            /*
             0 = tied
             1 = player wins
             2 = bot wins
             */

            if (PlayerSelection.Value == BotSelection.Value)
                WinningPlayerId = 0;
            if (PlayerSelection.Value == 0 && BotSelection.Value == 1)
                WinningPlayerId = 1;
            if (PlayerSelection.Value == 1 && BotSelection.Value == 0)
                WinningPlayerId = 2;
            if (PlayerSelection.Value == 1 && BotSelection.Value == 2)
                WinningPlayerId = 1;
            if (PlayerSelection.Value == 2 && BotSelection.Value == 1)
                WinningPlayerId = 2;
            if (PlayerSelection.Value == 2 && BotSelection.Value == 3)
                WinningPlayerId = 1;
            if (PlayerSelection.Value == 3 && BotSelection.Value == 2)
                WinningPlayerId = 2;
        }

        #endregion Methods
    }
}