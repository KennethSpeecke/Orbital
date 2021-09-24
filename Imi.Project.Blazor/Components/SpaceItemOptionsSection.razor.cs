using Imi.Project.Blazor.Models.Base;
using Microsoft.AspNetCore.Components;
using System;

namespace Imi.Project.Blazor.Components
{
    public partial class SpaceItemOptionsSection
    {
        #region Properties

        [Parameter]
        public BaseSpaceItem<Guid> CurrentSpaceItem { get; set; }

        [Parameter]
        public EventCallback<BaseSpaceItem<Guid>> OnCommentClick { get; set; }

        [Parameter]
        public EventCallback<BaseSpaceItem<Guid>> OnDeleteClick { get; set; }

        [Parameter]
        public EventCallback<BaseSpaceItem<Guid>> OnFavoriteClick { get; set; }

        [Parameter]
        public EventCallback<BaseSpaceItem<Guid>> OnUpdateClick { get; set; }

        #endregion Properties
    }
}