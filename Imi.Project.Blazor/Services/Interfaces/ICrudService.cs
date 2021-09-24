using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface ICrudService<T> where T : BaseSpaceItem<Guid>
    {
        #region Methods

        Task<T> Create(T itemToCreate);

        Task<T> Delete(T itemToDelete);

        Task<T> GetById(Guid id);

        Task<T[]> GetItemList();

        Task<T[]> GetItemsWithSpaceType(SpaceItemTypes spaceItemType);

        Task<T[]> GetItemsWithSpaceTypes(ICollection<SpaceItemTypes> spaceItemTypes);

        Task<T> GetNewItem();

        Task<T> Update(T itemToUpdate);

        #endregion Methods
    }
}