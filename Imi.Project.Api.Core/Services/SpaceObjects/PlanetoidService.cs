using AutoMapper;
using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.SpaceObjects
{
    public class PlanetoidService : IPlanetoidService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly ISpacePlanetoidRepository _spacePlanetoidRepository;

        #endregion Fields

        #region Constructors

        public PlanetoidService(IMapper mapper, ISpacePlanetoidRepository spacePlanetoidService, IPlanetoidCompositionService planetoidCompositionService)
        {
            _mapper = mapper;
            _spacePlanetoidRepository = spacePlanetoidService;
        }

        #endregion Constructors

        #region Methods

        public async Task<PlanetoidResponseDto> AddAsync(PlanetoidRequestDto dtoRequestModel)
        {
            var entityToAdd = _mapper.Map<SpacePlanetoidEntity>(dtoRequestModel);
            var result = await _spacePlanetoidRepository.AddAsync(entityToAdd);
            var responseDto = _mapper.Map<PlanetoidResponseDto>(result);
            return responseDto;
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PlanetoidResponseDto> GetByIdAsync(Guid id)
        {
            var foundPlanetoid = await _spacePlanetoidRepository.GetByIdAsync(id);
            var responseDto = _mapper.Map<PlanetoidResponseDto>(foundPlanetoid);
            return responseDto;
        }

        public async Task<IEnumerable<PlanetoidResponseDto>> ListAllAsync()
        {
            var planetoids = _spacePlanetoidRepository.GetAllAsync().ToList();
            var responseDto = _mapper.Map<IEnumerable<PlanetoidResponseDto>>(planetoids);
            return await Task.FromResult(responseDto);
        }

        public Task<PlanetoidResponseDto> UpdateAsync(PlanetoidRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}