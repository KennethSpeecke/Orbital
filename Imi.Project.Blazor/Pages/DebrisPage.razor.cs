using Imi.Project.Blazor.Extensions;
using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Enums;
using Imi.Project.Blazor.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Pages
{
    public partial class DebrisPage : ComponentBase
    {
        #region Fields

        private BaseSpaceItem<Guid> currentSpaceItem;
        private BaseSpaceItem<Guid>[] spaceItems = new BaseSpaceItem<Guid>[0];

        #endregion Fields

        #region Properties

        [Inject]
        public ICrudService<BaseSpaceItem<Guid>> service { get; set; }

        #endregion Properties

        #region Methods

        public Task AddToCurrentUserFavorites(BaseSpaceItem<Guid> spaceItem)
        {
            throw new NotImplementedException();
        }

        public Task CancelEditor()
        {
            currentSpaceItem.IsUpdateClicked = false;
            return Task.FromResult(currentSpaceItem);
        }

        public async Task<BaseSpaceItem<Guid>> DeleteCurrentSpaceItem(BaseSpaceItem<Guid> itemToDelete)
        {
            await service.Delete(itemToDelete);
            currentSpaceItem.IsUpdateClicked = false; //If we get here it means the delete went through with no way back. so prop is false;
            currentSpaceItem = null;
            return await Task.FromResult(currentSpaceItem);
        }

        public Task SaveEditor(BaseSpaceItem<Guid> spaceItem)
        {
            var foundItem = service.Update(spaceItem);
            currentSpaceItem.IsUpdateClicked = false; //If we get here it means the update went through. so prop is false;
            currentSpaceItem = null;
            return Task.FromResult(foundItem);
        }

        public async Task ShowInfoOfItem(BaseSpaceItem<Guid> spaceItem)
        {
            this.currentSpaceItem = await service.GetById(spaceItem.Id);
        }

        public Task UpdateCurrentSpaceItemEditState(BaseSpaceItem<Guid> spaceItem)
        {
            return Task.FromResult(currentSpaceItem = SpaceItemsExtensions.SetEditValue(spaceItem));
        }

        protected async override Task OnInitializedAsync()
        {
            spaceItems = await SpaceItemsExtensions.ShowListOfSpaceObjects(SpaceItemTypes.DEBRIS, service);
        }

        #endregion Methods
    }
}