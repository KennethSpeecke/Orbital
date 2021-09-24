using Imi.Project.Blazor.Models.Base;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;

namespace Imi.Project.Blazor.Components
{
    public partial class SpaceItemDetailed
    {
        #region Properties

        [Parameter]
        public BaseSpaceItem<Guid> CurrentSpaceItem { get; set; }

        #endregion Properties

        #region Methods

        private string SelectRandomItemImage()
        {
            return CurrentSpaceItem.ImageUrls.ToArray()[new Random().Next(0, CurrentSpaceItem.ImageUrls.Count)];
        }

        #endregion Methods
    }
}