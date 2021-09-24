using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.ObjectsTracking
{
    public interface IGeoLocationService<T>
    {
        #region Methods

        public Task<bool> CheckIfObjectsArePassingBy(ApplicationUserGeoLocationResponseDto staticObject, SpaceObjectGeoLocationResponseDto dynamicObject);

        public Task<T> GetGeoLocation();

        #endregion Methods
    }
}