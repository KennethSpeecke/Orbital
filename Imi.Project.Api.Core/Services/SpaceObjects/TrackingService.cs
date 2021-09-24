using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.ObjectsTracking;
using Imi.Project.Api.Core.Interfaces.Services.TLEDataServices;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.SpaceObjects
{
    public class TrackingService : ISpaceObjectLocationService
    {
        #region Fields

        private readonly ITLEDataWebClient _tleDataWebClient;

        #endregion Fields

        #region Constructors

        public TrackingService(ITLEDataWebClient tleDataWebClient)
        {
            _tleDataWebClient = tleDataWebClient;
        }

        #endregion Constructors

        #region Methods

        public async Task<bool> CheckIfObjectsArePassingBy(ApplicationUserGeoLocationResponseDto staticObject, SpaceObjectGeoLocationResponseDto dynamicObject)
        {
            var distSq =
                ((staticObject.Latitude - staticObject.Longtitude) *
                    (staticObject.Latitude - staticObject.Longtitude)) +
                ((dynamicObject.Latitude - dynamicObject.Longtitude) *
                    (dynamicObject.Longtitude - dynamicObject.Longtitude));

            var radSumSq = (staticObject.VisibleRange + dynamicObject.Range) * (staticObject.VisibleRange + dynamicObject.Range);

            if (distSq == radSumSq)
            {
                return await Task.FromResult(true);
            }
            else if (distSq > radSumSq)
                return await Task.FromResult(false);
            else
                return await Task.FromResult(false);
        }

        public Task<SpaceObjectGeoLocationResponseDto> GetGeoLocation()
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}