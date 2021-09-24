using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.Scientists
{
    public class AstronomerRequestDto : BaseScientistDto
    {
        #region Properties

        public byte TotalActiveWorkingYears { get; set; }
        public int TotalDiscoveriesMade { get; set; }

        #endregion Properties
    }
}