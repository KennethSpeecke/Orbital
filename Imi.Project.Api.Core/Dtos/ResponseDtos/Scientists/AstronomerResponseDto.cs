using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists
{
    public class AstronomerResponseDto : BaseScientistDto
    {
        #region Properties

        public int AmountOfNotableWorks { get; set; }
        public byte TotalActiveWorkingYears { get; set; }

        public int TotalDiscoveriesMade { get; set; }

        #endregion Properties
    }
}