using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ApplicationRoleSeeder
    {
        #region Fields

        private const string adminRoleId = "47b4def6-770c-4df9-ab97-c010904574a6";
        private const string adminRoleName = "admin";
        private const string adminRoleNormalizedName = "ADMIN";

        private const string memberRoleId = "db2ad43a-9f3f-45fd-8b28-068dbc58b799";
        private const string memberRoleName = "member";
        private const string memberRoleNormalizedName = "MEMBER";

        private IPasswordHasher<ApplicationUser> _passwordHasher;

        #endregion Fields

        #region Constructors

        public ApplicationRoleSeeder(IPasswordHasher<ApplicationUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        #endregion Constructors

        #region Methods

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = adminRoleId,
                    Name = adminRoleName,
                    NormalizedName = adminRoleNormalizedName
                },
                new IdentityRole()
                {
                    Id = memberRoleId,
                    Name = memberRoleName,
                    NormalizedName = memberRoleNormalizedName
                });
        }

        #endregion Methods
    }
}