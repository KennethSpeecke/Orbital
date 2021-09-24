using Newtonsoft.Json;
using System;

namespace Imi.Project.Api.Core.Dtos.Bases
{
    public class BaseGeoLocationDto : BaseDto<Guid>
    {
        #region Properties

        [JsonProperty("iss_location.latitude")]
        public double Latitude { get; set; }

        public double Longtitude { get; set; }

        public double Range { get; set; }

        #endregion Properties
    }
}