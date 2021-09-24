using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects
{
    public class PlanetoidResponseDto : BaseSpaceObjectDto
    {
        #region Properties

        public string Composition { get; set; }
        public string Shape { get; set; }

        #endregion Properties
    }
}