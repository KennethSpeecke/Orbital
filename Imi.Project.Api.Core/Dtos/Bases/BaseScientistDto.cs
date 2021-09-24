using System;

namespace Imi.Project.Api.Core.Dtos.Bases
{
    public class BaseScientistDto : BaseDto<Guid>
    {
        #region Properties

        public byte Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public DateTime ObitDate { get; set; }
        public string Surname { get; set; }

        #endregion Properties
    }
}