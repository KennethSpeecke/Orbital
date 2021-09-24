using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Interfaces.Repositories.Scientists;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Imi.Project.Api.Infrastructure.Repositories.Scientists
{
    public class AstronomerRepository : EfRepository<AstronomerEntity>, IAstronomerRepository
    {
        #region Constructors

        public AstronomerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<AstronomerEntity> GetAllAsync()
        {
            return _dbContext.Astronomers.AsNoTracking()
                .Include(a => a.NotableWorks);
        }

        #endregion Methods
    }
}