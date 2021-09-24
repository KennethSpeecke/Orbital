using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects
{
    public class SpaceObjectGeoLocationResponseDto : BaseGeoLocationDto
    {
        #region Properties

        public double AngleVector { get; set; }
        public double RelativeSpeed { get; set; }

        #endregion Properties
    }
}