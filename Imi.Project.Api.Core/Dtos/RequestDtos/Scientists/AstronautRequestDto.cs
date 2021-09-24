using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.Scientists
{
    public class AstronautRequestDto : BaseScientistDto
    {
        #region Properties

        public bool IsCurrentlyActiveInSpace { get; set; }
        public int MemberOfAmountOfSpaceCrews { get; set; }
        public DateTime TimeInSpace { get; set; }
        public DateTime TimeServedForMilitary { get; set; }
        public int TotalMissions { get; set; }

        #endregion Properties
    }
}