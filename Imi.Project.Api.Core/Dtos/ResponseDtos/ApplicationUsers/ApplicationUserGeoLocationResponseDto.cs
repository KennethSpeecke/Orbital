using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers
{
    public class ApplicationUserGeoLocationResponseDto : BaseGeoLocationDto
    {
        #region Properties

        public double VisibleRange { get; } = 3.5;

        #endregion Properties
    }
}