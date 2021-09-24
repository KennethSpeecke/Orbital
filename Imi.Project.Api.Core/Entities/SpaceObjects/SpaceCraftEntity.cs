using Imi.Project.Api.Core.Entities.Base;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.SpaceObjects
{
    public class SpaceCraftEntity : BaseSpaceEntity
    {
        #region Properties

        public string MissionInformation { get; set; }

        //Navigation Properties
        public ICollection<SpaceCraftCrew> SpaceCraftCrews { get; set; }

        #endregion Properties
    }
}