using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Enums;
using Imi.Project.Blazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Extensions
{
    public static class SpaceItemsExtensions
    {
        #region Methods

        public static BaseSpaceItem<Guid> SetEditValue(BaseSpaceItem<Guid> baseSpaceItem)
        {
            if (baseSpaceItem.IsUpdateClicked == null || baseSpaceItem.IsUpdateClicked == false)
            {
                baseSpaceItem.IsUpdateClicked = true;
            }
            else
                baseSpaceItem.IsUpdateClicked = false;

            return baseSpaceItem;
        }

        public async static Task<BaseSpaceItem<Guid>[]> ShowListOfSpaceObjects(SpaceItemTypes spaceItemTypes, ICrudService<BaseSpaceItem<Guid>> service)
        {
            return await service.GetItemsWithSpaceType(spaceItemTypes);
        }

        public async static Task<BaseSpaceItem<Guid>[]> ShowListOfSpaceObjects(ICollection<SpaceItemTypes> spaceItemTypes, ICrudService<BaseSpaceItem<Guid>> service)
        {
            return await service.GetItemsWithSpaceTypes(spaceItemTypes);
        }

        public async static Task<BaseSpaceItem<Guid>[]> ShowListOfSpaceObjects(ICrudService<BaseSpaceItem<Guid>> service)
        {
            return await service.GetItemList();
        }

        #endregion Methods
    }
}