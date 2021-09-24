using Imi.Project.Blazor.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models.SpaceObjects
{
    public class SpaceCraftModel : BaseSpaceItem<Guid>
    {
        #region Properties

        [Required]
        [StringLength(500, ErrorMessage = "Mission Information can only contain 500 characters.")]
        public string MissionInformation { get; set; }

        #endregion Properties

        //Why is the craft there doing what its doing?
    }
}