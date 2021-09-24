using Imi.Project.Api.Core.Dtos.Bases;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects
{
    public class PlanetoidRequestDto : BaseSpaceObjectDto
    {
        #region Properties

        public Guid AstronomerId { get; set; }
        public string AstronomerName { get; set; }
        public ICollection<PlanetoidCompositionRequestDto> Compositions { get; set; }
        public string Shape { get; set; }

        #endregion Properties
    }
}