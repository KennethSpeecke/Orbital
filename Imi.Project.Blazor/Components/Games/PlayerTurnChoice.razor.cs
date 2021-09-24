using Imi.Project.Blazor.Models.Games.PlanetoidDebrisCrafts;
using Microsoft.AspNetCore.Components;

namespace Imi.Project.Blazor.Components.Games
{
    public partial class PlayerTurnChoice
    {
        #region Properties

        [ParameterAttribute]
        public EventCallback<Models.Games.PlanetoidDebrisCrafts.PossibleSelections> ChoiceSelected { get; set; }

        #endregion Properties

        #region Methods

        public void TriggerDebris()
        {
            ChoiceSelected.InvokeAsync(PossibleSelections.Debris);
        }

        public void TriggerPlanet()
        {
            ChoiceSelected.InvokeAsync(PossibleSelections.Planet);
        }

        public void TriggerSpaceCraft()
        {
            ChoiceSelected.InvokeAsync(PossibleSelections.SpaceCraft);
        }

        #endregion Methods
    }
}