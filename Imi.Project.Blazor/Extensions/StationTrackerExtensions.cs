using Imi.Project.Blazor.Models.Maps;
using Imi.Project.Blazor.Services.Interfaces;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Extensions
{
    public static class StationTrackerExtensions
    {
        #region Methods

        public static async Task<Marker> GetCurrentIssLocation(IZayraLocationService zayraLocationService)
        {
            var currentZayraLocation = await zayraLocationService.GetCurrentIssLocation();
            return currentZayraLocation;
        }

        #endregion Methods
    }
}