using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Scientists;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.SpaceObjects
{
    public class SpacePlanetoidEntity : BaseSpaceEntity
    {
        #region Properties

        public AstronomerEntity Astronomer { get; set; }
        public Guid AstronomerId { get; set; }
        public ICollection<PlanetoidComposition> Compositions { get; set; }
        public string Shape { get; set; }

        #endregion Properties
    }
}