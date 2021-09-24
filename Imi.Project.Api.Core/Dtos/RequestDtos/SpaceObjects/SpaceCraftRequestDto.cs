using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects
{
    public class SpaceCraftRequestDto : BaseSpaceObjectDto
    {
        #region Properties

        public string MissionInformation { get; set; }

        #endregion Properties
    }
}