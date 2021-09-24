using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ObjectsTracking;

namespace Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers
{
    public interface IUserLocationService : IGeoLocationService<ApplicationUserGeoLocationResponseDto>
    {
    }
}