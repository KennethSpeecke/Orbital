using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.Scientists
{
    public class SpaceCrewRequestDto
    {
        #region Properties

        public AstronautRequestDto Astronaut { get; set; }
        public SpaceCraftRequestDto SpaceCraft { get; set; }

        #endregion Properties
    }
}