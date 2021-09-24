using Imi.Project.Api.Core.Dtos.Bases;
using System;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Core.Dtos.RequestDtos.Scientists
{
    public class NotableWorkRequestDto : BaseDto<Guid>
    {
        #region Properties

        [JsonIgnore] //We ignore the json value here because this property gets set by a parameter given with the controller route.
        public Guid AstronomerId { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }

        #endregion Properties
    }
}