using Imi.Project.Blazor.Models.Base;
using Microsoft.AspNetCore.Components;
using System;

namespace Imi.Project.Blazor.Components
{
    public partial class SpaceItemListCarousel
    {
        #region Properties

        [Parameter]
        public BaseSpaceItem<Guid>[] SpaceItems { get; set; }

        #endregion Properties
    }
}