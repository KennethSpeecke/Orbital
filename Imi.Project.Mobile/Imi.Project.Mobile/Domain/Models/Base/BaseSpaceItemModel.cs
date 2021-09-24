using Imi.Project.Mobile.Domain.Models.Enums;
using System.Collections.Generic;

namespace Imi.Project.Mobile.Domain.Models.Base
{
    public abstract class BaseSpaceItemModel<TKey>
    {
        #region Properties

        public int Apogee { get; set; }
        public TKey Id { get; set; }
        public ICollection<string> ImageUrls { get; set; }

        //User related properties
        public bool IsFavorite { get; set; }

        public double Mass { get; set; }
        public string Name { get; set; } //Full name of space item

                                         //Highest point of items orbit path
        public int Perigee { get; set; }

        public string ShortName { get; set; } //Shortend name of space item

                                              //The mass of the space item
        public double Size { get; set; }

        //Lowest point of items orbit path
        public SpaceItemTypes SpaceItemType { get; set; } //The type of the space item

                                                          //The size of the object
        public string ThumbnailImage { get; set; }

        #endregion Properties

        //Has user favorited the item?
    }
}