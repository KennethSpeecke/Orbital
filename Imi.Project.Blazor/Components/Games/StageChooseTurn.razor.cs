using Microsoft.AspNetCore.Components;

namespace Imi.Project.Blazor.Components.Games
{
    public partial class StageChooseTurn
    {
        #region Properties

        [ParameterAttribute]
        public EventCallback<Models.Games.PlanetoidDebrisCrafts.PossibleSelections> OnClickChoice { get; set; }

        #endregion Properties
    }
}