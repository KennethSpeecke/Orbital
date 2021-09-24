using Imi.Project.Api.Core.Entities.Bases;
using System;

namespace Imi.Project.Api.Core.Entities.Scientists
{
    public class NotableWorkEntity : BaseEntity<Guid>
    {
        #region Properties

        public AstronomerEntity Astronomer { get; set; }
        public Guid AstronomerId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        #endregion Properties
    }
}