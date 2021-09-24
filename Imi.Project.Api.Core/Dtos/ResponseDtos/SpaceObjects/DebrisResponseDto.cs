using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects
{
    public class DebrisResponseDto : BaseSpaceObjectDto
    {
        #region Properties

        public bool IsOnCollisionCourse { get; set; }

        #endregion Properties
    }
}