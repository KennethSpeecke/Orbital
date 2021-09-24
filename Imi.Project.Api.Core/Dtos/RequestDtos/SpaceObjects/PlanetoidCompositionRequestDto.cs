using Imi.Project.Api.Core.Dtos.Bases;
using Imi.Project.Api.Core.Entities.Enums;
using System;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects
{
    public class PlanetoidCompositionRequestDto : BaseDto<Guid>
    {
        #region Properties

        public PlanetoidCompositions CompositionType { get; set; }

        #endregion Properties
    }
}