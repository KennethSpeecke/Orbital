using Imi.Project.Api.Core.Dtos.Bases;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers
{
    public class ApplicationUserResponseDto : BaseDto<Guid>
    {
        public ICollection<ApplicationUserCommentResponseDto> ApplicationUserComments { get; set; }
    }
}