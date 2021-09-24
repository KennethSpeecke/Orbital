using AutoMapper;
using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.SpaceObjects
{
    public class SpaceCraftService : ISpaceCraftService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly ISpaceCraftRepository _spaceCraftRepository;

        #endregion Fields

        #region Constructors

        public SpaceCraftService(ISpaceCraftRepository spaceCraftRepository, IMapper mapper)
        {
            _spaceCraftRepository = spaceCraftRepository;
            _mapper = mapper;
        }

        #endregion Constructors

        #region Methods

        public Task<SpaceCraftResponseDto> AddAsync(SpaceCraftRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SpaceCraftResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<SpaceCraftResponseDto> GetByIdAsync(Guid id, bool isMannedType)
        {
            var foundItem = await _spaceCraftRepository.GetByIdAsync(id, isMannedType);
            var responseDto = _mapper.Map<SpaceCraftResponseDto>(foundItem);
            return await Task.FromResult(responseDto);
        }

        public async Task<IEnumerable<SpaceCraftResponseDto>> ListAllAsync()
        {
            var spaceCrafts = _spaceCraftRepository.GetAllAsync().ToList();
            var responseDto = _mapper.Map<IEnumerable<SpaceCraftResponseDto>>(spaceCrafts);
            return await Task.FromResult(responseDto);
        }

        public async Task<IEnumerable<SpaceCraftResponseDto>> ListAllByMannedTypeAsync(bool isMannedCraft)
        {
            var spaceCrafts = new List<SpaceCraftEntity>();
            var responseDtos = new List<SpaceCraftResponseDto>();

            if (isMannedCraft)
            {
                spaceCrafts = _spaceCraftRepository.GetAllAsync().Where(p => p.SpaceObjectType == Entities.Enums.SpaceObjectTypes.MANNEDCRAFT).ToList();
                responseDtos = _mapper.Map<IEnumerable<SpaceCraftResponseDto>>(spaceCrafts).ToList();
                return await Task.FromResult(responseDtos);
            }
            else
            {
                spaceCrafts = _spaceCraftRepository.GetAllAsync().Where(p => p.SpaceObjectType == Entities.Enums.SpaceObjectTypes.UNMANNEDCRAFT).ToList();
                responseDtos = _mapper.Map<IEnumerable<SpaceCraftResponseDto>>(spaceCrafts).ToList();
                return await Task.FromResult(responseDtos);
            }
        }

        public Task<SpaceCraftResponseDto> UpdateAsync(SpaceCraftRequestDto dtoRequestModel)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}