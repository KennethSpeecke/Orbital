using Imi.Project.Blazor.Models.Base;
using Microsoft.AspNetCore.Components;
using System;

namespace Imi.Project.Blazor.Components
{
    public partial class SpaceItemsTable
    {
        #region Properties

        [Parameter]
        public EventCallback<BaseSpaceItem<Guid>> OnFavoriteClick { get; set; }

        [Parameter]
        public BaseSpaceItem<Guid>[] SpaceItems { get; set; }

        #endregion Properties
    }
}