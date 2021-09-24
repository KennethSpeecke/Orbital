using Imi.Project.Api.Core.Entities.Bases;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.Scientists
{
    public class AstronautEntity : BaseScientistEntity
    {
        #region Properties

        public bool IsCurrentlyActiveInSpace { get; set; }

        //Navigation Properties
        public ICollection<SpaceCraftCrew> SpaceCraftCrews { get; set; }

        public DateTime TimeInSpace { get; set; }
        public DateTime TimeServedForMilitary { get; set; }
        public int TotalMissions { get; set; }

        #endregion Properties
    }
}