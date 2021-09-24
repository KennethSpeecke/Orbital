using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.SpaceObjects
{
    public class SpacePlanetoidRepository : EfRepository<SpacePlanetoidEntity>, ISpacePlanetoidRepository
    {
        #region Constructors

        public SpacePlanetoidRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<SpacePlanetoidEntity> GetAllAsync()
        {
            return _dbContext.Planetoids.AsNoTracking()
                .Include(p => p.Astronomer)
                .Include(p => p.Compositions)
                .Include(p => p.UserComments)
                .Include(p => p.FavoriteUserObjects);
        }

        public override Task<SpacePlanetoidEntity> GetByIdAsync(Guid id)
        {
            return _dbContext.Planetoids
                        .Include(p => p.Compositions)
                    .Where(p => p.Id.Equals(id))
                    .SingleOrDefaultAsync();
        }

        #endregion Methods
    }
}