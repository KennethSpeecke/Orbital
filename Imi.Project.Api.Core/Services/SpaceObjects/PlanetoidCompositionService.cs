using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.SpaceObjects
{
    public class PlanetoidCompositionService : IPlanetoidCompositionService
    {
        #region Methods

        public Task<PlanetoidCompositionResponseDto> AddAsync(PlanetoidCompositionRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PlanetoidCompositionResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PlanetoidComposition> GetByPlanetoidId(Guid planetoidId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlanetoidCompositionResponseDto>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlanetoidCompositionResponseDto> UpdateAsync(PlanetoidCompositionRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}