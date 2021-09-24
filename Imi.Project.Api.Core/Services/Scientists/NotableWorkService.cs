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
    public class NotableWorkService : INotableWorkService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly INotableWorkRepository _notableWorkRepository;

        #endregion Fields

        #region Constructors

        public NotableWorkService(INotableWorkRepository notableWorkRepository, IMapper mapper)
        {
            _notableWorkRepository = notableWorkRepository;
            _mapper = mapper;
        }

        #endregion Constructors

        #region Methods

        public async Task<NotableWorkResponseDto> AddAsync(NotableWorkRequestDto dtoRequestModel)
        {
            var notableworkEntity = _mapper.Map<NotableWorkEntity>(dtoRequestModel);
            await _notableWorkRepository.AddAsync(notableworkEntity);
            var responseDto = _mapper.Map<NotableWorkResponseDto>(notableworkEntity);
            return responseDto;
        }

        public async Task<NotableWorkResponseDto> AddAsync(NotableWorkRequestDto dtoRequestModel, Guid astronomerId)
        {
            var notableworkEntity = _mapper.Map<NotableWorkEntity>(dtoRequestModel);
            notableworkEntity.AstronomerId = astronomerId;
            await _notableWorkRepository.AddAsync(notableworkEntity);
            var responseDto = _mapper.Map<NotableWorkResponseDto>(notableworkEntity);
            return responseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _notableWorkRepository.DeleteAsync(id);
        }

        public async Task<NotableWorkResponseDto> GetByIdAsync(Guid id)
        {
            var foundItem = _mapper.Map<NotableWorkResponseDto>(await _notableWorkRepository.GetByIdAsync(id));
            return foundItem;
        }

        public async Task<IEnumerable<NotableWorkResponseDto>> ListAllAsync()
        {
            var notableWorks = _notableWorkRepository.GetAllAsync();
            var responseDto = _mapper.Map<IEnumerable<NotableWorkResponseDto>>(notableWorks);
            return await Task.FromResult(responseDto);
        }

        public async Task<NotableWorkResponseDto> UpdateAsync(NotableWorkRequestDto dtoRequestModel)
        {
            var notableworkEntity = _mapper.Map<NotableWorkEntity>(dtoRequestModel);
            await _notableWorkRepository.UpdateAsync(notableworkEntity);
            var responseDto = _mapper.Map<NotableWorkResponseDto>(notableworkEntity);
            return responseDto;
        }

        public async Task<NotableWorkResponseDto> UpdateAsync(NotableWorkRequestDto dtoRequestModel, Guid astronomerId)
        {
            var notableworkEntity = _mapper.Map<NotableWorkEntity>(dtoRequestModel);
            notableworkEntity.AstronomerId = astronomerId;
            await _notableWorkRepository.UpdateAsync(notableworkEntity);
            var responseDto = _mapper.Map<NotableWorkResponseDto>(notableworkEntity);
            return responseDto;
        }

        #endregion Methods
    }
}