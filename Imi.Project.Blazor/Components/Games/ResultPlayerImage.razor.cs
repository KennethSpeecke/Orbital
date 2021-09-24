using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using Microsoft.AspNetCore.Components;
using System;

namespace Imi.Project.Blazor.Components.Games
{
    public partial class ResultPlayerImage
    {
        #region Properties

        public string ImageName
        {
            get
            {
                switch (PlayerChoice.Value)
                {
                    case 0:
                        return "Games/planet";

                    case 1:
                        return "Games/spacecraft";

                    case 2:
                        return "Games/debris";

                    default:
                        throw new Exception("Not a valid choice");
                }
            }
        }

        [Parameter]
        public bool IsWinner { get; set; }

        [Parameter]
        public Selection PlayerChoice { get; set; }

        public string WinnerClass
        {
            get
            {
                return IsWinner ? "winner" : "loser";
            }
        }

        #endregion Properties
    }
}