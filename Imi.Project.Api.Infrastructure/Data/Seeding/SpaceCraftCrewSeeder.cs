using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class SpaceCraftCrewSeeder
    {
        const string sunitaAstronautId = "0168ae99-7a93-49cd-8d96-832b5d8e5383";
        const string edwardAstronautId = "6491a95e-872a-438c-8f0d-a0991e3f48bc";
        const string peggyAstronautId = "3ef70e4c-74a9-4f46-b017-005e95310401";
        const string buzzAstronautId = "5fd739f5-fed9-4345-94db-c58e27790aff";
        const string susanAstronautId = "2198a48e-2f27-4d09-a264-08913c18d1db";


        const string issCraftId = "0a612c41-d1e7-41c3-8a40-880e3beb0333";
        const string crewDragonId = "f148f935-84ad-41c3-aebd-9d183d9e7e6a";



        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<SpaceCraftCrew>().HasData(
                    new SpaceCraftCrew { AstronautId = Guid.Parse(sunitaAstronautId), SpaceCraftId = Guid.Parse(issCraftId)},
                    new SpaceCraftCrew { AstronautId = Guid.Parse(edwardAstronautId), SpaceCraftId = Guid.Parse(issCraftId)},
                    new SpaceCraftCrew { AstronautId = Guid.Parse(peggyAstronautId), SpaceCraftId = Guid.Parse(crewDragonId)},
                    new SpaceCraftCrew { AstronautId = Guid.Parse(buzzAstronautId), SpaceCraftId = Guid.Parse(issCraftId)},
                    new SpaceCraftCrew { AstronautId = Guid.Parse(susanAstronautId), SpaceCraftId = Guid.Parse(issCraftId)}
                );
        }
    }
}
