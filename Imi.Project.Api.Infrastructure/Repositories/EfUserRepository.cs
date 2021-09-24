using Imi.Project.Api.Core.Interfaces;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class EfUserRepository<T> : IRepository<T> where T : IdentityUser
    {
        #region Fields

        protected readonly ApplicationDbContext _dbContext;

        #endregion Fields

        #region Constructors

        public EfUserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion Constructors

        #region Methods

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}