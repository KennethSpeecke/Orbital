using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IGeoLocation
    {
        #region Methods

        Task<Location> GetLastKnownUserLocation();

        Task<Location> GetUserLocation();

        #endregion Methods
    }
}