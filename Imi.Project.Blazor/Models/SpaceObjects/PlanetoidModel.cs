using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Enums;
using Imi.Project.Blazor.Models.Scientists;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models.SpaceObjects
{
    public class PlanetoidModel : BaseSpaceItem<Guid>
    {
        #region Properties

        public ICollection<PlanetoidCompositions> Compossision { get; set; }

        [Required]
        public AstronomerModel Discoverer { get; set; }

        [Required]
        public string Shape { get; set; }

        #endregion Properties

        //The shape of the planetoid
        //Person who discoverd the planetoid
        //The composition of the planetoid
    }
}