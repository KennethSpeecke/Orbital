using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects
{
    public class PlanetoidCompositionResponseDto : BaseDto<Guid>
    {
        #region Properties

        public string CompositionType { get; set; }

        #endregion Properties
    }
}