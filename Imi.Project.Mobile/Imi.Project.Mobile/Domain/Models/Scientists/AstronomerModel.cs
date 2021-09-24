using Imi.Project.Mobile.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models.Scientists
{
    public class AstronomerModel : BasePersonModel<Guid>
    {
        public int TotalDiscoveriesMade { get; set; }
        public byte TotalActiveWorkingYears { get; set; }
        public ICollection<string> NotableWorks { get; set; }
    }
}
