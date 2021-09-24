using Imi.Project.Api.Core.Entities.SpaceObjects;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects
{
    public interface ISpaceCraftRepository : IRepository<SpaceCraftEntity>
    {
        #region Methods

        public Task<SpaceCraftEntity> GetByIdAsync(Guid id, bool isMannedType);

        #endregion Methods
    }
}