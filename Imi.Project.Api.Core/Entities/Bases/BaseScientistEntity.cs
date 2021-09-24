using System;

namespace Imi.Project.Api.Core.Entities.Bases
{
    public abstract class BaseScientistEntity : BaseEntity<Guid>
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