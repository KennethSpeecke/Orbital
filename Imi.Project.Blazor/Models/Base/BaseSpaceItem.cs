using Imi.Project.Blazor.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models.Base
{
    public abstract class BaseSpaceItem<TKey>
    {
        #region Properties

        [Required]
        public int Apogee { get; set; }

        [Required]
        public TKey Id { get; set; }

        public ICollection<string> ImageUrls { get; set; }

        public bool IsFavorite { get; set; }

        public bool? IsUpdateClicked { get; set; }

        //GeoLocation property
        public double Latitude { get; set; }

        //GeoLocation property
        public double Longtitude { get; set; }

        [Required]
        public double Mass { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "Name of the object must be between 2 and 45 characters long.", MinimumLength = 2)]
        public string Name { get; set; } //Full name of space item

        //Highest point of items orbit path
        [Required]
        public int Perigee { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Shortname of the object must be between 2 and 15 characters long.", MinimumLength = 2)]
        public string ShortName { get; set; } //Shortend name of space item

        //The mass of the space item
        [Required]
        public double Size { get; set; }

        //Lowest point of items orbit path
        [Required]
        public SpaceItemTypes SpaceItemType { get; set; }

        #endregion Properties
    }
}