using Imi.Project.Blazor.Models.Base;
using Microsoft.AspNetCore.Components;
using System;

namespace Imi.Project.Blazor.Components
{
    public partial class SpaceItemEditForm
    {
        #region Properties

        [Parameter]
        public BaseSpaceItem<Guid> ItemToEdit { get; set; }

        [Parameter]
        public EventCallback OnCancelClick { get; set; }

        [Parameter]
        public EventCallback<BaseSpaceItem<Guid>> OnSaveClick { get; set; }

        #endregion Properties
    }
}