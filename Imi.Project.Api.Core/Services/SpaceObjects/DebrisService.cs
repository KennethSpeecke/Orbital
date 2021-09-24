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
    public class DebrisService : IDebrisService
    {
        #region Fields

        private readonly ISpaceDebrisRepository _debrisRepository;
        private readonly IMapper _mapper;

        #endregion Fields

        #region Constructors

        public DebrisService(ISpaceDebrisRepository debrisRepository, IMapper mapper)
        {
            _debrisRepository = debrisRepository;
            _mapper = mapper;
        }

        #endregion Constructors

        #region Methods

        public async Task<DebrisResponseDto> AddAsync(DebrisRequestDto dtoRequestModel)
        {
            var debrisEntity = _mapper.Map<SpaceDebrisEntity>(dtoRequestModel);
            await _debrisRepository.AddAsync(debrisEntity);
            var response = _mapper.Map<DebrisResponseDto>(debrisEntity);
            return response;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _debrisRepository.DeleteAsync(id);
        }

        public async Task<DebrisResponseDto> GetByIdAsync(Guid id)
        {
            var responseDto = _mapper.Map<DebrisResponseDto>(await _debrisRepository.GetByIdAsync(id));
            return responseDto;
        }

        public async Task<IEnumerable<DebrisResponseDto>> ListAllAsync()
        {
            var debris = _debrisRepository.GetAllAsync().ToList();
            var responseDto = _mapper.Map<IEnumerable<DebrisResponseDto>>(debris);
            return await Task.FromResult(responseDto);
        }

        public async Task<DebrisResponseDto> UpdateAsync(DebrisRequestDto dtoRequestModel)
        {
            var debrisEntity = _mapper.Map<SpaceDebrisEntity>(dtoRequestModel);
            await _debrisRepository.UpdateAsync(debrisEntity);
            var response = _mapper.Map<DebrisResponseDto>(debrisEntity);
            return response;
        }

        #endregion Methods
    }
}