using Imi.Project.Api.Core.Entities.Bases;
using Imi.Project.Api.Core.Interfaces;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity<Guid>
    {
        #region Fields

        protected readonly ApplicationDbContext _dbContext;

        #endregion Fields

        #region Constructors

        public EfRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion Constructors

        #region Methods

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                await _dbContext.Set<T>().AddAsync(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public async Task<T> DeleteAsync(T entity)
        {
            try
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public async Task<T> DeleteAsync(Guid id)
        {
            try
            {
                var entityToDelete = await GetByIdAsync(id);
                await DeleteAsync(entityToDelete);
                return entityToDelete;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public virtual IQueryable<T> GetAllAsync()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                var foundItem = await _dbContext.Set<T>().FindAsync(id);
                return foundItem;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public async Task<T> GetByIdAsync(Guid id, string[] includes)
        {
            try
            {
                var query = _dbContext.Set<T>().AsNoTracking().AsQueryable();

                foreach (var fieldToInclude in includes)
                {
                    query.Include(fieldToInclude);
                }
                return await query.SingleOrDefaultAsync(item => item.Id.Equals(id));
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _dbContext.Set<T>().Where(predicate).AsNoTracking().AsQueryable();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public async virtual Task<IEnumerable<T>> ListAllAsync()
        {
            try
            {
                return await GetAllAsync().AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await GetFiltered(predicate).AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                throw new Exception(e.Message);
            }
        }

        #endregion Methods
    }
}