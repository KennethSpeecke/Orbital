using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IZayraLocationService
    {
        #region Methods

        Task<Location> GetCurrentIssLocation();

        #endregion Methods
    }
}