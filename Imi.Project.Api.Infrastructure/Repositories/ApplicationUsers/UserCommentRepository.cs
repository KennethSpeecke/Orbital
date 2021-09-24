using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Repositories.ApplicationUsers;
using Imi.Project.Api.Infrastructure.Data.Context;

namespace Imi.Project.Api.Infrastructure.Repositories.ApplicationUsers
{
    public class UserCommentRepository : EfRepository<UserComment>, IUserCommentRepository
    {
        #region Constructors

        public UserCommentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        #endregion Constructors
    }
}