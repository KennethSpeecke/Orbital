using Imi.Project.Api.Core.Entities.Scientists;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class AstronautSeeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<AstronautEntity>().HasData(
                    new AstronautEntity { Id = Guid.Parse("0168ae99-7a93-49cd-8d96-832b5d8e5383"), Name = "Sunita", Surname = "Williams", BirthDate = DateTime.Parse("Sep 16, 1965"), ObitDate = DateTime.MinValue, Age = 56, IsCurrentlyActiveInSpace = true, TimeInSpace = DateTime.MinValue.AddDays(321), TimeServedForMilitary = DateTime.MinValue, TotalMissions = 4 },
                    new AstronautEntity { Id = Guid.Parse("6491a95e-872a-438c-8f0d-a0991e3f48bc"), Name = "Edward", Surname = "White", BirthDate = DateTime.Parse("Nov 14, 1930"), ObitDate = DateTime.Parse("Jan 27, 1967"), Age = 36, IsCurrentlyActiveInSpace = false, TimeInSpace = DateTime.MinValue.AddDays(4), TimeServedForMilitary = DateTime.MinValue.AddYears(20), TotalMissions = 2 },
                    new AstronautEntity { Id = Guid.Parse("3ef70e4c-74a9-4f46-b017-005e95310401"), Name = "Peggy", Surname = "Whitson", BirthDate = DateTime.Parse("Feb 9, 1960"), ObitDate = DateTime.MinValue, Age = 61, IsCurrentlyActiveInSpace = false, TimeInSpace = DateTime.MinValue.AddDays(665), TimeServedForMilitary = DateTime.MinValue, TotalMissions = 3 },
                    new AstronautEntity { Id = Guid.Parse("5fd739f5-fed9-4345-94db-c58e27790aff"), Name = "Buzz", Surname = "Aldrin", BirthDate = DateTime.Parse("Jan 20, 1930"), ObitDate = DateTime.MinValue, Age = 99, IsCurrentlyActiveInSpace = false, TimeInSpace = DateTime.MinValue.AddDays(12), TimeServedForMilitary = DateTime.MinValue, TotalMissions = 2 },
                    new AstronautEntity { Id = Guid.Parse("2198a48e-2f27-4d09-a264-08913c18d1db"), Name = "Susan", Surname = "Jane Helms", BirthDate = DateTime.Parse("Feb 26, 1958"), ObitDate = DateTime.MinValue, Age = 63, IsCurrentlyActiveInSpace = false, TimeInSpace = DateTime.MinValue.AddDays(210), TimeServedForMilitary = DateTime.MinValue.AddYears(34), TotalMissions = 7 }
                );
        }
    }
}
