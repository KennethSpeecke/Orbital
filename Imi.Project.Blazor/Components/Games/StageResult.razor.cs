using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using Microsoft.AspNetCore.Components;
using System;

namespace Imi.Project.Blazor.Components.Games
{
    public partial class StageResult
    {
        #region Properties

        [ParameterAttribute]
        public EventCallback NewRound { get; set; }

        [Parameter]
        public Selection Player1Choice { get; set; }

        [Parameter]
        public Selection Player2Choice { get; set; }

        [Parameter]
        public int WinningPlayerId { get; set; }

        private string WinningPlayer
        {
            get
            {
                switch (WinningPlayerId)
                {
                    case 0:
                        return "This game ended in a draw!";

                    case 1:
                        return "You won the game!";

                    case 2:
                        return "Your opponent won the game!";

                    default:
                        throw new Exception("There are only two players in this game!");
                }
            }
        }

        #endregion Properties
    }
}