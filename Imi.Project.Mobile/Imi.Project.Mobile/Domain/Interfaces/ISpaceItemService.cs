using Imi.Project.Mobile.Domain.Models.Enums;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface ISpaceItemService<T> where T : SpaceBaseItemViewModel<Guid>
    {
        #region Methods

        Task<T> AddAsync(T item);

        Task<T> DeleteAsync(T item);

        Task<T> DeleteAsync(Guid id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllTrackableAsync();

        Task<T> GetByIdAsync(Guid id);

        Task<T> GetByIdAsync(Guid id, string[] includes);

        Task<T> GetByIdAsync(Guid id, SpaceItemTypes spaceItemType);

        Task<IEnumerable<T>> GetSpaceItemsByType(SpaceItemTypes spaceItemType);

        Task<T> UpdateAsync(T item);

        #endregion Methods
    }
}