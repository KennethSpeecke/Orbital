using Imi.Project.Mobile.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models.Scientists
{
    public class AstronautModel : BasePersonModel<Guid>
    {
        public bool IsCurrentlyActiveInSpace { get; set; }
        public ICollection<string> Crews { get; set; }
        public DateTime TimeServedForMilitary { get; set; }
        public DateTime TimeInSpace { get; set; }
        public int TotalMissions { get; set; }
    }
}
