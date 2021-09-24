using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects
{
    public class IssResponseDto : BaseGeoLocationDto
    {
        #region Properties

        public BaseGeoLocationDto Iss_Location { get; set; }

        #endregion Properties
    }
}