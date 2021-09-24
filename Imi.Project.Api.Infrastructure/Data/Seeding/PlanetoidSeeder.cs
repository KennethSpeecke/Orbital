using Imi.Project.Api.Core.Entities.Enums;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class PlanetoidSeeder
    {
        const string marcAstronomerId = "87e606a8-8674-4442-bc23-a5893a4d8721";
        const string morioAstronomerId = "b3eab1b9-7806-4153-b3cd-6131bac6fea9";
        const string antonioAstronomerId = "2cfd4710-3af2-421c-8ebb-262b5b092a92";
        const string luisAstronomerId = "6bf00c4f-c458-465a-9073-3c4531650133";
        const string marceloAstronomerId = "cb4e377d-f341-4c60-9efc-7cc02a8c1df9";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpacePlanetoidEntity>().HasData(
                new SpacePlanetoidEntity { Id = Guid.Parse("d607b31e-7705-4cfe-b433-01c5ca7b2529"), Name = "Hydra", ShortName = "S/2005", ApogeeInKm = 38, PerigeeInKm = 38, AstronomerId = Guid.Parse(marceloAstronomerId), Latitude = 0, Longtitude = 0, Mass = 4877, Shape = "Oval", Size = 5752, SpaceObjectType = SpaceObjectTypes.PLANETOID, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                new SpacePlanetoidEntity { Id = Guid.Parse("540ddc41-0631-409e-a09f-bae6d95cbe8b"), Name = "Kerberos", ShortName = "S/2011", ApogeeInKm = 32, PerigeeInKm = 31, AstronomerId = Guid.Parse(morioAstronomerId), Latitude = 0, Longtitude = 0, Mass = 1676, Shape = "Sphere", Size = 1710, SpaceObjectType = SpaceObjectTypes.PLANETOID, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                new SpacePlanetoidEntity { Id = Guid.Parse("e295c1f3-6f37-400a-b066-b99b06cb01c3"), Name = "1566 Icarus", ShortName = "1566Ica", ApogeeInKm = 31, PerigeeInKm = 47, AstronomerId = Guid.Parse(luisAstronomerId), Latitude = 22.826, Longtitude = 88.005, Mass = 147, Shape = "Oval", Size = 671, SpaceObjectType = SpaceObjectTypes.PLANETOID, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                new SpacePlanetoidEntity { Id = Guid.Parse("cb83c7e6-6c8c-4e38-8f1e-356ccfabcfc0"), Name = "1685 Toro", ShortName = "Tor", ApogeeInKm = 45, PerigeeInKm = 47, AstronomerId = Guid.Parse(antonioAstronomerId), Latitude = 0, Longtitude = 0, Mass = 3454, Shape = "Egg", Size = 2457, SpaceObjectType = SpaceObjectTypes.PLANETOID, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                new SpacePlanetoidEntity { Id = Guid.Parse("f78cd23d-0ba6-4e64-86bb-d183a274f1f6"), Name = "1981 Midas", ShortName = "Midas", ApogeeInKm = 78, PerigeeInKm = 68, AstronomerId = Guid.Parse(marcAstronomerId), Latitude = 0, Longtitude = 0, Mass = 2579, Shape = "Sphere", Size = 5478, SpaceObjectType = SpaceObjectTypes.PLANETOID, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) }
                );
        }
    }
}
