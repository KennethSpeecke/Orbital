using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Interfaces.Repositories.Scientists;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Imi.Project.Api.Infrastructure.Repositories.Scientists
{
    public class AstronautRepository : EfRepository<AstronautEntity>, IAstronautRepository
    {
        #region Constructors

        public AstronautRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<AstronautEntity> GetAllAsync()
        {
            return _dbContext.Astronauts.AsNoTracking()
                .Include(a => a.SpaceCraftCrews)
                    .ThenInclude(scc => scc.SpaceCraft);
        }

        #endregion Methods
    }
}