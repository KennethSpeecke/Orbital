using Imi.Project.Api.Core.Dtos.Bases;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects
{
    public class DebrisRequestDto : BaseSpaceObjectDto
    {
        #region Properties

        public bool IsOnCollisionCourse { get; set; }

        #endregion Properties
    }
}