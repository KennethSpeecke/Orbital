using Imi.Project.Api.Core.Dtos.Bases;
using Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects
{
    public class SpaceCraftResponseDto : BaseSpaceObjectDto
    {
        #region Properties

        public string MissionInformation { get; set; }
        public ICollection<SpaceCrewResponseDto> SpaceCrews { get; set; }

        #endregion Properties
    }
}