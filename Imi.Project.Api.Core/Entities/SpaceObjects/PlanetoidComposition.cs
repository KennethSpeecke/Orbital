using Imi.Project.Api.Core.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.SpaceObjects
{
    public class PlanetoidComposition
    {
        public Guid Id { get; set; }
        public PlanetoidCompositions TypeName { get; set; }

        public Guid PlanetoidId { get; set; }
        public SpacePlanetoidEntity Planetoid { get; set; }
    }
}
