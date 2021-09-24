using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists
{
    public class NotableWorkResponseDto : BaseDto<Guid>
    {
        #region Properties

        public Guid AstronomerId { get; set; }
        public string AstronomerName { get; set; }
        public string AstronomerSurname { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        #endregion Properties
    }
}