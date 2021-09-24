using AutoMapper;
using Imi.Project.Api.Core.Dtos.RequestDtos.Scientists;
using Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists;
using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Interfaces.Repositories.Scientists;
using Imi.Project.Api.Core.Interfaces.Services.Scientists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Scientists
{
    public class AstronautService : IAstronautService
    {
        #region Fields

        private readonly IAstronautRepository _astronautRepository;
        private readonly IMapper _mapper;

        #endregion Fields

        #region Constructors

        public AstronautService(IAstronautRepository astronautRepository, IMapper mapper)
        {
            _astronautRepository = astronautRepository;
            _mapper = mapper;
        }

        #endregion Constructors

        #region Methods

        public async Task<AstronautResponseDto> AddAsync(AstronautRequestDto dtoRequestModel)
        {
            var astronautEntry = _mapper.Map<AstronautEntity>(dtoRequestModel);
            await _astronautRepository.AddAsync(astronautEntry);
            var astronautResponseDto = _mapper.Map<AstronautResponseDto>(astronautEntry);
            return astronautResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _astronautRepository.DeleteAsync(id);
        }

        public async Task<AstronautResponseDto> GetByIdAsync(Guid id)
        {
            var foundAstronaut = await _astronautRepository.GetByIdAsync(id);
            var responseDto = _mapper.Map<AstronautResponseDto>(foundAstronaut);
            return responseDto;
        }

        public async Task<IEnumerable<AstronautResponseDto>> ListAllAsync()
        {
            var astronauts = _astronautRepository.GetAllAsync().ToList();
            var responseDto = _mapper.Map<IEnumerable<AstronautResponseDto>>(astronauts);
            return await Task.FromResult(responseDto);
        }

        public async Task<AstronautResponseDto> UpdateAsync(AstronautRequestDto dtoRequestModel)
        {
            var astronautEntity = _mapper.Map<AstronautEntity>(dtoRequestModel);
            var result = await _astronautRepository.UpdateAsync(astronautEntity);
            var responseDto = _mapper.Map<AstronautResponseDto>(result);
            return responseDto;
        }

        #endregion Methods
    }
}