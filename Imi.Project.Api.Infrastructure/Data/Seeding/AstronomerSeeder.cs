using Imi.Project.Api.Core.Entities.Scientists;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class AstronomerSeeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<AstronomerEntity>().HasData(
                    new AstronomerEntity { Id = Guid.Parse("87e606a8-8674-4442-bc23-a5893a4d8721"), Name = "Marc", Surname = "Aaronson", Age = 36, BirthDate = DateTime.Parse("Aug 24, 1950"), ObitDate = DateTime.Parse("Apr 30, 1987"), TotalActiveWorkingYears = 21, TotalDiscoveriesMade = 11},
                    new AstronomerEntity { Id = Guid.Parse("b3eab1b9-7806-4153-b3cd-6131bac6fea9"), Name = "Norio", Surname = "Kaifu", Age = 75, BirthDate = DateTime.Parse("Sep 21, 1950"), ObitDate = DateTime.Parse("Apr 13, 2019"), TotalActiveWorkingYears = 47, TotalDiscoveriesMade = 3},
                    new AstronomerEntity { Id = Guid.Parse("2cfd4710-3af2-421c-8ebb-262b5b092a92"), Name = "Antonio", Surname = "Abetti", Age = 81, BirthDate = DateTime.Parse("Jun 19, 1846"), ObitDate = DateTime.Parse("Feb 20, 1928"), TotalActiveWorkingYears = 41, TotalDiscoveriesMade = 4},
                    new AstronomerEntity { Id = Guid.Parse("6bf00c4f-c458-465a-9073-3c4531650133"), Name = "Luis", Surname = "Cruls", Age = 60, BirthDate = DateTime.Parse("Jan 21, 1848"), ObitDate = DateTime.Parse("Jun 21, 1908"), TotalActiveWorkingYears = 39, TotalDiscoveriesMade = 17},
                    new AstronomerEntity { Id = Guid.Parse("cb4e377d-f341-4c60-9efc-7cc02a8c1df9"), Name = "Marcelo", Surname = "Gleiser", Age = 61, BirthDate = DateTime.Parse("Mar 19, 1959"), ObitDate = DateTime.MinValue, TotalActiveWorkingYears = 40, TotalDiscoveriesMade = 6}
                );
        }
    }
}
