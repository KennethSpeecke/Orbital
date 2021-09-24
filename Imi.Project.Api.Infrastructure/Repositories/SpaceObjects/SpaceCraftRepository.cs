using Imi.Project.Api.Core.Entities.Enums;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.SpaceObjects
{
    public class SpaceCraftRepository : EfRepository<SpaceCraftEntity>, ISpaceCraftRepository
    {
        #region Constructors

        public SpaceCraftRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<SpaceCraftEntity> GetAllAsync()
        {
            return _dbContext.SpaceCrafts.AsNoTracking()
                .Include(sc => sc.SpaceCraftCrews)
                    .ThenInclude(scc => scc.Astronaut)
                .Include(sc => sc.FavoriteUserObjects)
                .Include(sc => sc.Images)
                .Include(sc => sc.UserComments);
        }

        public Task<SpaceCraftEntity> GetByIdAsync(Guid id, bool isMannedType)
        {
            if (isMannedType)
            {
                return _dbContext.SpaceCrafts.AsNoTracking()
                            .Include(sc => sc.SpaceCraftCrews)
                                .ThenInclude(scc => scc.Astronaut)
                            .Include(sc => sc.Images)
                        .Where(sc => sc.Id.Equals(id) && sc.SpaceObjectType.Equals(SpaceObjectTypes.MANNEDCRAFT))
                        .SingleOrDefaultAsync();
            }
            else
            {
                return _dbContext.SpaceCrafts.AsNoTracking()
                        .Include(sc => sc.SpaceCraftCrews)
                            .ThenInclude(scc => scc.Astronaut)
                        .Include(sc => sc.Images)
                    .Where(sc => sc.Id.Equals(id) && sc.SpaceObjectType.Equals(SpaceObjectTypes.UNMANNEDCRAFT))
                    .SingleOrDefaultAsync();
            }
        }

        #endregion Methods
    }
}