using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers
{
    public class ApplicationUserCommentResponseDto : BaseDto<Guid>
    {
        #region Properties

        public string Text { get; set; }

        #endregion Properties
    }
}