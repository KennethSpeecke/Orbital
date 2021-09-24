using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ApplicationUserSeeder //Pure test data once identity is implemented this shall be removed. Hashed MD5 passwords
    {
        #region Methods

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(
                    new ApplicationUser { Id = "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", Email = "AdmiralChunky@mailinator.com", UserName = "Admiral Chuncky", PasswordHash = "4D3C54A22A97802627566A24F2DC7C1B" },
                    new ApplicationUser { Id = "34d82894-cd34-40a6-a19e-881ca98451f7", Email = "ColonelChunky@mailinator.com", UserName = "Colonel Chuncky", PasswordHash = "CE071784473D4E694D397DA4ECB5219E" },
                    new ApplicationUser { Id = "86b9ff3d-5188-43e5-9c8d-f7f46823ce73", Email = "SergeantChunky@mailinator.com", UserName = "Sergeant Chuncky", PasswordHash = "6074E512F4F844BD415C5941A41BE25F" },
                    new ApplicationUser { Id = "8d5213cb-1abc-43e3-a4d6-35b92e829f6f", Email = "CorporalChunky@mailinator.com", UserName = "Corporal Chuncky", PasswordHash = "27CFC5E4E4AF55E4A67D22B5C080F750" },
                    new ApplicationUser { Id = "ced8f1e3-fbab-4db1-99a1-fa45b1428c21", Email = "RecruitChunky@mailinator.com", UserName = "Recruit Chuncky", PasswordHash = "9F3171B314D1869C68B0E9F82C087BF9" }
                );
        }

        #endregion Methods
    }
}