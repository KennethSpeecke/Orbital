using Imi.Project.Api.Core.Entities.Enums;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class SpaceCraftSeeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<SpaceCraftEntity>().HasData(
                    new SpaceCraftEntity { Id = Guid.Parse("e50a22c0-30e1-4d72-9f0b-ed259ee27514"),  Name = "Starlink V1", ShortName = "SlV1", ApogeeInKm = 550, PerigeeInKm = 550, Latitude = 0, Longtitude = 0, Mass = 260, MissionInformation = "Starlink is SpaceX's 12000-satellite low earth orbit constellation to provide broadband Internet access.", Size = 2, SpaceObjectType = SpaceObjectTypes.UNMANNEDCRAFT, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                    new SpaceCraftEntity { Id = Guid.Parse("f148f935-84ad-41c3-aebd-9d183d9e7e6a"),  Name = "Crew Dragon", ShortName = "C-DA", ApogeeInKm = 0, PerigeeInKm = 0, Latitude = 0, Longtitude = 0, Mass = 9616, MissionInformation = "Crew dragon created by spacex is designed to send humans to space and back to earth in a costeffective manner.", Size = 8, SpaceObjectType = SpaceObjectTypes.MANNEDCRAFT, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                    new SpaceCraftEntity { Id = Guid.Parse("d62bbcec-6e3a-416f-a5e3-d77fbee675d6"),  Name = "Cargo Dragon", ShortName = "CA-DA", ApogeeInKm = 0, PerigeeInKm = 0, Latitude = 0, Longtitude = 0, Mass = 7415, MissionInformation = "Dragon created by spacex is designed to send cargo to space and back to earth in a costeffective manner", Size = 8, SpaceObjectType = SpaceObjectTypes.UNMANNEDCRAFT, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                    new SpaceCraftEntity { Id = Guid.Parse("0a612c41-d1e7-41c3-8a40-880e3beb0333"),  Name = "International Space Station", ShortName = "ISS", ApogeeInKm = 421, PerigeeInKm = 417, Latitude = 0, Longtitude = 0, Mass = 419725, MissionInformation = "he ISS was originally intended to be a laboratory, observatory, and factory while providing transportation, maintenance, and a low Earth orbit staging base for possible future missions to the Moon, Mars, and asteroids.", Size = 915, SpaceObjectType = SpaceObjectTypes.MANNEDCRAFT, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) },
                    new SpaceCraftEntity { Id = Guid.Parse("4ef5c419-655a-440b-967c-65c79bf243d3"),  Name = "Atlas V-541", ShortName = "AT-V-541", ApogeeInKm = 0, PerigeeInKm = 0, Latitude = 0, Longtitude = 0, Mass = 531000, MissionInformation = "This launch vehicle provides the velocity needed by a spacecraft to escape Earth's gravity and set it on its course for Mars.", Size = 58, SpaceObjectType = SpaceObjectTypes.MANNEDCRAFT, ThumbnailImage = new Uri("default.jpg", UriKind.Relative) }
                );
        }
    }
}
