using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Services.OrbitalApi;
using Imi.Project.Mobile.ViewModels.ObjectTracker.SpecificObjects;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Imi.Project.Mobile.Domain.Services.Locations
{
    public class IssLocationService : IZayraLocationService
    {
        #region Fields

        private readonly string _openNotifyBaseUrl;

        #endregion Fields

        #region Constructors

        public IssLocationService()
        {
            _openNotifyBaseUrl = "http://api.open-notify.org/iss-now.json";
        }

        #endregion Constructors

        #region Methods

        public async Task<Location> GetCurrentIssLocation()
        {
            var currentIssLocation = await WebApiClient.GetApiResult<ZayraLocationViewModel>(_openNotifyBaseUrl);
            return new Location() { Latitude = currentIssLocation.Iss_Position.Latitude, Longitude = currentIssLocation.Iss_Position.Longitude };
        }

        #endregion Methods
    }
}