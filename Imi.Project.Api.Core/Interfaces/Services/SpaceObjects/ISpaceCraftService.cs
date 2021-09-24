using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.SpaceObjects
{
    public interface ISpaceCraftService : IService<SpaceCraftResponseDto, SpaceCraftRequestDto>
    {
        #region Methods

        public Task<SpaceCraftResponseDto> GetByIdAsync(Guid id, bool isMannedType);

        public Task<IEnumerable<SpaceCraftResponseDto>> ListAllByMannedTypeAsync(bool isMannedCraft);

        #endregion Methods
    }
}