using Imi.Project.Api.Core.Entities.Enums;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DebrisSeeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<SpaceDebrisEntity>().HasData(
                new SpaceDebrisEntity { Id = Guid.Parse("46f23e53-093c-44ab-9427-9b03cd08dd8f"), Name = "Cosmos 2251", ShortName = "036BXZ", ApogeeInKm = 760, PerigeeInKm = 736, IsOnCollisionCourse = false, Mass = 15437.15, Size = 12, SpaceObjectType = SpaceObjectTypes.DEBRIS,Latitude = 0, Longtitude = 0, ThumbnailImage = new Uri("ThnCosmos2251.jpg", UriKind.Relative)},
                new SpaceDebrisEntity { Id = Guid.Parse("ffebf84b-b0cd-4bab-91a6-dd3024f81968"), Name = "Iridium 33", ShortName = "051DG", ApogeeInKm = 899, PerigeeInKm = 756, IsOnCollisionCourse = true, Mass = 241, Size = 1, SpaceObjectType = SpaceObjectTypes.DEBRIS,Latitude = 0, Longtitude = 0, ThumbnailImage = new Uri("ThnIridium33.jpg", UriKind.Relative) },
                new SpaceDebrisEntity { Id = Guid.Parse("99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d"), Name = "SL-16RB", ShortName = "SL16", ApogeeInKm = 848, PerigeeInKm = 837, IsOnCollisionCourse = false, Mass = 9000, Size = 7, SpaceObjectType = SpaceObjectTypes.DEBRIS,Latitude = 0, Longtitude = 0, ThumbnailImage = new Uri("ThnSL16.jpg", UriKind.Relative) },
                new SpaceDebrisEntity { Id = Guid.Parse("4fd5e7e7-3516-425a-a8c7-28ee8b89596a"), Name = "Envisat", ShortName = "Esat", ApogeeInKm = 766, PerigeeInKm = 764, IsOnCollisionCourse = true, Mass = 7800, Size = 2, SpaceObjectType = SpaceObjectTypes.DEBRIS,Latitude = 0, Longtitude = 0, ThumbnailImage = new Uri("ThnEnvisat.jpg", UriKind.Relative) },
                new SpaceDebrisEntity { Id = Guid.Parse("5552205c-ad29-4f80-adb1-c357b17373f8"), Name = "Adeos", ShortName = "Adeos", ApogeeInKm = 794, PerigeeInKm = 793, IsOnCollisionCourse = true, Mass = 3560, Size = 7, SpaceObjectType = SpaceObjectTypes.DEBRIS,Latitude = 0, Longtitude = 0, ThumbnailImage = new Uri("ThnAdeos.jpg", UriKind.Relative) }
                );
        }
    }
}
