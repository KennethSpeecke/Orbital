using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists
{
    public class SpaceCrewResponseDto : BaseDto<Guid>
    {
        #region Properties

        public string AstronautName { get; set; }
        public string AstronautSurName { get; set; }
        public string SpaceCraftName { get; set; }

        #endregion Properties
    }
}