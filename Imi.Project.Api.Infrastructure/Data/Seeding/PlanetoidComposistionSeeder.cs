using Imi.Project.Api.Core.Entities.Enums;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class PlanetoidComposistionSeeder
    {
        const string hydraPlanetoidId = "d607b31e-7705-4cfe-b433-01c5ca7b2529";
        const string kerberosPlanetoidId = "540ddc41-0631-409e-a09f-bae6d95cbe8b";
        const string icarusPlanetoidId = "e295c1f3-6f37-400a-b066-b99b06cb01c3";
        const string toroPlanetoidId = "cb83c7e6-6c8c-4e38-8f1e-356ccfabcfc0";
        const string midasPlanetoidId = "f78cd23d-0ba6-4e64-86bb-d183a274f1f6";

        public static void Seed(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<PlanetoidComposition>().HasData(
                    new PlanetoidComposition { Id = Guid.Parse("896bf05c-4ceb-4077-b3aa-b84eb7c63754"), TypeName = PlanetoidCompositions.SOLID, PlanetoidId = Guid.Parse(hydraPlanetoidId)},
                    new PlanetoidComposition { Id = Guid.Parse("7c217060-1ba2-42de-bfd1-e8120939b582"), TypeName = PlanetoidCompositions.LIQUID, PlanetoidId = Guid.Parse(hydraPlanetoidId)},
                    new PlanetoidComposition { Id = Guid.Parse("14915d9f-0b10-4589-9a17-f6baaa5c8d74"), TypeName = PlanetoidCompositions.LIQUID, PlanetoidId = Guid.Parse(kerberosPlanetoidId)},
                    new PlanetoidComposition { Id = Guid.Parse("72767dda-f6be-4cee-99ac-b4e627ba524a"), TypeName = PlanetoidCompositions.SOLID, PlanetoidId = Guid.Parse(kerberosPlanetoidId)},
                    new PlanetoidComposition { Id = Guid.Parse("3819da10-9c39-44de-87e4-d945fa8a0aee"), TypeName = PlanetoidCompositions.SOLID, PlanetoidId = Guid.Parse(icarusPlanetoidId)},
                    new PlanetoidComposition { Id = Guid.Parse("42ebc493-704d-4ff2-b296-c056faa894f5"), TypeName = PlanetoidCompositions.SOLID, PlanetoidId = Guid.Parse(toroPlanetoidId)},
                    new PlanetoidComposition { Id = Guid.Parse("3e7c9638-2ca6-413d-8e57-1e279645249d"), TypeName = PlanetoidCompositions.LIQUID, PlanetoidId = Guid.Parse(midasPlanetoidId)}
                );
        }
    }
}
