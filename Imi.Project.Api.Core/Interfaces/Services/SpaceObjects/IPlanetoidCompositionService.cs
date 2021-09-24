using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.SpaceObjects
{
    public interface IPlanetoidCompositionService : IService<PlanetoidCompositionResponseDto, PlanetoidCompositionRequestDto>
    {
        #region Methods

        Task<PlanetoidComposition> GetByPlanetoidId(Guid planetoidId);

        #endregion Methods
    }
}