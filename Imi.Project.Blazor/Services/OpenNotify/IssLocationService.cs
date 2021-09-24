using Imi.Project.Blazor.Models.Maps;
using Imi.Project.Blazor.Models.SpaceObjects;
using Imi.Project.Blazor.Services.Interfaces;
using Imi.Project.Blazor.Services.WebClient;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.OpenNotify
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

        public async Task<Marker> GetCurrentIssLocation()
        {
            var currentIssLocation = await WebApiClient.GetApiResult<ZayraLocationModel>(_openNotifyBaseUrl);
            return new Marker() { Latitude = currentIssLocation.Iss_Position.Latitude, Longitude = currentIssLocation.Iss_Position.Longitude };
        }

        #endregion Methods
    }
}