using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class SpaceCraftCrew
    {
        public Guid AstronautId { get; set; }
        public Guid SpaceCraftId { get; set; }

        public AstronautEntity Astronaut { get; set; }
        public SpaceCraftEntity SpaceCraft { get; set; }
    }
}
