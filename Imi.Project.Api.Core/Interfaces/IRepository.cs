using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        #region Methods

        Task<T> AddAsync(T entity);

        Task<T> DeleteAsync(T entity);

        Task<T> DeleteAsync(Guid id);

        IQueryable<T> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task<T> GetByIdAsync(Guid id, string[] includes);

        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> ListAllAsync();

        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);

        Task<T> UpdateAsync(T entity);

        #endregion Methods
    }
}