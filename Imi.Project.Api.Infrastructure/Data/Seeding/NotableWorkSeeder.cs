using Imi.Project.Api.Core.Entities.Scientists;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class NotableWorkSeeder
    {
        const string marcAstronomerId = "87e606a8-8674-4442-bc23-a5893a4d8721";
        const string morioAstronomerId = "b3eab1b9-7806-4153-b3cd-6131bac6fea9";
        const string antonioAstronomerId = "2cfd4710-3af2-421c-8ebb-262b5b092a92";
        const string luisAstronomerId = "6bf00c4f-c458-465a-9073-3c4531650133";
        const string marceloAstronomerId = "cb4e377d-f341-4c60-9efc-7cc02a8c1df9";
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<NotableWorkEntity>().HasData(
                    new NotableWorkEntity { Id = Guid.Parse("a8aa9aac-7a91-4f7d-8daf-5d31e0b756ff"), AstronomerId = Guid.Parse(marcAstronomerId), Title = "BOOMERanG experiment", Description = "The BOOMERanG experiment (Balloon Observations Of Millimetric Extragalactic Radiation ANd Geophysics) was an experiment which measured the cosmic microwave background radiation of a part of the sky during three sub-orbital (high-altitude) balloon flights." },
                    new NotableWorkEntity { Id = Guid.Parse("a5a2f47f-97e0-4110-976b-41294db83111"), AstronomerId = Guid.Parse(morioAstronomerId), Title = " Nishina Memorial Prize", Description = "The oldest and most prestigious physics award in Japan." },
                    new NotableWorkEntity { Id = Guid.Parse("511e4a30-8ef6-46e7-9852-b579c6e3d617"), AstronomerId = Guid.Parse(antonioAstronomerId), Title = "Planet Discoveries", Description = "Found 89 Planet systems." },
                    new NotableWorkEntity { Id = Guid.Parse("03803688-5986-4cb4-a197-5758c7fa7a7c"), AstronomerId = Guid.Parse(luisAstronomerId), Title = "Imperial Observatory", Description = "Founded the Imperial Observatory now known as The National Observatory (Brazil)." },
                    new NotableWorkEntity { Id = Guid.Parse("e92e08ae-82af-4025-962b-1956934bd31a"), AstronomerId = Guid.Parse(marceloAstronomerId), Title = "Templeton Prize", Description = "The Templeton Prize is an annual award granted to a living person, in the estimation of the judges, whose exemplary achievements advance Sir John Templeton's philanthropic vision: harnessing the power of the sciences to explore the deepest questions of the universe and humankind’s place and purpose within it."}
                );
        }
    }
}
