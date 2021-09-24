using Imi.Project.Api.Core.Dtos.RequestDtos.Scientists;
using Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Scientists
{
    public interface INotableWorkService : IService<NotableWorkResponseDto, NotableWorkRequestDto>
    {
        #region Methods

        public Task<NotableWorkResponseDto> AddAsync(NotableWorkRequestDto dtoRequestModel, Guid astronomerId);

        public Task<NotableWorkResponseDto> UpdateAsync(NotableWorkRequestDto dtoRequestModel, Guid astronomerId);

        #endregion Methods
    }
}