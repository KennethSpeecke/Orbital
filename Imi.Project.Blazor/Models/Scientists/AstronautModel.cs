using Imi.Project.Blazor.Models.Base;
using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Models.Scientists
{
    public class AstronautModel : BasePersonModel<Guid>
    {
        #region Properties

        public ICollection<string> Crews { get; set; }
        public bool IsCurrentlyActiveInSpace { get; set; }
        public DateTime TimeInSpace { get; set; }
        public DateTime TimeServedForMilitary { get; set; }
        public int TotalMissions { get; set; }

        #endregion Properties
    }
}