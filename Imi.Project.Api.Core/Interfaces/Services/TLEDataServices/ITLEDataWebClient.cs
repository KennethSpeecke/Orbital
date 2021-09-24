using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.TLEDataServices
{
    public interface ITLEDataWebClient
    {
        #region Methods

        public Task<string> GetSpaceDataFromSpaceTrack(string[] noradPredicates, DateTime dtstart, DateTime dtend);

        public Task<string> GetSpaceDataFromSpaceTrack(string[] noradPredicates);

        #endregion Methods
    }
}