using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Enums;
using Imi.Project.Blazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.OrbitalApi
{
    public class SpaceItemService : ICrudService<BaseSpaceItem<Guid>>
    {
        #region Methods

        public Task<BaseSpaceItem<Guid>> Create(BaseSpaceItem<Guid> itemToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>> Delete(BaseSpaceItem<Guid> itemToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>[]> GetItemList()
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>[]> GetItemsWithSpaceType(SpaceItemTypes spaceItemType)
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>[]> GetItemsWithSpaceTypes(ICollection<SpaceItemTypes> spaceItemTypes)
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>> GetNewItem()
        {
            throw new NotImplementedException();
        }

        public Task<BaseSpaceItem<Guid>> Update(BaseSpaceItem<Guid> itemToUpdate)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}