using Imi.Project.Mobile.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models.SpaceObjects
{
    public class SpaceCraftModel : BaseSpaceItemModel<Guid>
    {
        public bool IsMannedCraft { get; set; } //Is the craft manned or not? Are humans or any sentient being on the craft?
        public string MissionInformation { get; set; } //Why is the craft there doing what its doing?

    }
}
