using AutoMapper;
using Imi.Project.Api.Core.Dtos.RequestDtos.Scientists;
using Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists;
using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Interfaces.Repositories.Scientists;
using Imi.Project.Api.Core.Interfaces.Services.Scientists;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Scientists
{
    public class AstronomerService : IAstronomerService
    {
        #region Fields

        private readonly IAstronomerRepository _astronomerRepository;
        private readonly IMapper _mapper;

        #endregion Fields

        #region Constructors

        public AstronomerService(IAstronomerRepository astronomerRepository, IMapper mapper)
        {
            _astronomerRepository = astronomerRepository;
            _mapper = mapper;
        }

        #endregion Constructors

        #region Methods

        public async Task<AstronomerResponseDto> AddAsync(AstronomerRequestDto dtoRequestModel)
        {
            var astronomerEntity = _mapper.Map<AstronomerEntity>(dtoRequestModel);
            await _astronomerRepository.AddAsync(astronomerEntity);
            var responseDto = _mapper.Map<AstronomerResponseDto>(astronomerEntity);
            return responseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _astronomerRepository.DeleteAsync(id);
        }

        public async Task<AstronomerResponseDto> GetByIdAsync(Guid id)
        {
            var foundAstronomer = _mapper.Map<AstronomerResponseDto>(await _astronomerRepository.GetByIdAsync(id));
            return foundAstronomer;
        }

        public async Task<IEnumerable<AstronomerResponseDto>> ListAllAsync()
        {
            var astronomers = _astronomerRepository.GetAllAsync();
            var responseDto = _mapper.Map<IEnumerable<AstronomerResponseDto>>(astronomers);
            return await Task.FromResult(responseDto);
        }

        public async Task<AstronomerResponseDto> UpdateAsync(AstronomerRequestDto dtoRequestModel)
        {
            var astronomerEntry = _mapper.Map<AstronomerEntity>(dtoRequestModel);
            await _astronomerRepository.UpdateAsync(astronomerEntry);
            return await GetByIdAsync(astronomerEntry.Id);
        }

        #endregion Methods
    }
}