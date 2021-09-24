using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Interfaces.Repositories.Scientists;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Imi.Project.Api.Infrastructure.Repositories.Scientists
{
    public class NotableWorkRepository : EfRepository<NotableWorkEntity>, INotableWorkRepository
    {
        #region Constructors

        public NotableWorkRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<NotableWorkEntity> GetAllAsync()
        {
            return _dbContext.NotableWorks.AsNoTracking()
                .Include(nw => nw.Astronomer);
        }

        #endregion Methods
    }
}