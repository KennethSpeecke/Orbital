using Imi.Project.Api.Core.Dtos.Bases;
using System;

namespace Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers
{
    public class ApplicationUserFavoriteResponseDto : BaseDto<Guid>
    {
        #region Properties

        public BaseSpaceObjectDto FavoriteObject { get; set; }

        #endregion Properties
    }
}