using Imi.Project.Blazor.Models.Maps;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface IZayraLocationService
    {
        #region Methods

        Task<Marker> GetCurrentIssLocation();

        #endregion Methods
    }
}