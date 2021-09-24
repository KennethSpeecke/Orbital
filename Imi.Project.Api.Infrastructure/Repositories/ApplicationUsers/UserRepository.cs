using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Repositories.ApplicationUsers;
using Imi.Project.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.ApplicationUsers
{
    public class UserRepository : EfUserRepository<ApplicationUser>, IUserRepository
    {
        #region Constructors

        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors

        #region Methods

        public override IQueryable<ApplicationUser> GetAllAsync()
        {
            //return _dbContext.ApplicationUsers.AsNoTracking()
            //    .Include(user => user.FavoriteUserObjects)
            //        .ThenInclude(fuo => fuo.SpaceObject)
            //            .ThenInclude(so => so.Images)
            //    .Include(user => user.UserComments);
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetUserByEmail(string userEmail)
        {
            return _dbContext.ApplicationUsers.AsNoTracking()
                .Include(u => u.UserComments)
                .Include(u => u.FavoriteUserObjects)
                    .Where(u => u.Email.Equals(userEmail))
                        .FirstOrDefaultAsync();
        }

        #endregion Methods
    }
}