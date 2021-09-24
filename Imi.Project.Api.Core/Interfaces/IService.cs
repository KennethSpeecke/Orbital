using Imi.Project.Api.Core.Dtos.Bases;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces
{
    public interface IService<TOut, TIn> where TOut : BaseDto<Guid>
    {
        #region Methods

        Task<TOut> AddAsync(TIn dtoRequestModel);

        Task DeleteAsync(Guid id);

        Task<TOut> GetByIdAsync(Guid id);

        Task<IEnumerable<TOut>> ListAllAsync();

        Task<TOut> UpdateAsync(TIn dtoRequestModel);

        #endregion Methods
    }
}