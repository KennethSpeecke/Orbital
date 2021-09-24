using Imi.Project.Api.Core.Entities.Bases;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Imi.Project.Api.Core.Entities.Scientists
{
    public class AstronomerEntity : BaseScientistEntity
    {
        #region Properties

        [JsonIgnore]
        public ICollection<NotableWorkEntity> NotableWorks { get; set; }

        public byte TotalActiveWorkingYears { get; set; }
        public int TotalDiscoveriesMade { get; set; }

        #endregion Properties
    }
}