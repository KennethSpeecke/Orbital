using Imi.Project.Api.Core.Dtos.RequestDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Core.Services.ApplicationUsers
{
    public class UserCommentService : IUserCommentService
    {
        #region Methods

        public Task<ApplicationUserCommentResponseDto> AddAsync(ApplicationUserCommentRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserCommentResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUserCommentResponseDto>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserCommentResponseDto> UpdateAsync(ApplicationUserCommentRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}