using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;

namespace Imi.Project.Api.Core.Interfaces.Services.ObjectsTracking
{
    public interface ISpaceObjectLocationService : IGeoLocationService<SpaceObjectGeoLocationResponseDto>
    {
    }
}