using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Imi.Project.Api.Infrastructure.Repositories.SpaceObjects
{
    public class SpaceDebrisRepository : EfRepository<SpaceDebrisEntity>, ISpaceDebrisRepository
    {
        #region Constructors

        public SpaceDebrisRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<SpaceDebrisEntity> GetAllAsync()
        {
            var result = _dbContext.Debris.AsNoTracking()
                .Include(d => d.Images).AsNoTracking();
            //.Include(d => d.UserComments)
            //.Include(d => d.FavoriteUserObjects);
            return result;
        }

        #endregion Methods
    }
}