using Imi.Project.Blazor.Models.Base;
using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Models.Scientists
{
    public class AstronomerModel : BasePersonModel<Guid>
    {
        #region Properties

        public ICollection<string> NotableWorks { get; set; }
        public byte TotalActiveWorkingYears { get; set; }
        public int TotalDiscoveriesMade { get; set; }

        #endregion Properties
    }
}