using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers
{
    public class ApplicationUserLoginResponseDto : BaseDto<Guid>
    {
        #region Properties

        public string ResponseToken { get; set; }

        #endregion Properties
    }
}