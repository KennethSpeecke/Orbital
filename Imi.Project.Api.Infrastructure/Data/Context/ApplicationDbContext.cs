using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Bases;
using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #region Constructors

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #endregion Constructors

        #region Properties

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<AstronautEntity> Astronauts { get; set; }
        public DbSet<AstronomerEntity> Astronomers { get; set; }
        public DbSet<SpaceDebrisEntity> Debris { get; set; }
        public DbSet<FavoriteUserObject> FavoriteUserObjects { get; set; }
        public DbSet<BaseImageEntity> ImageEntities { get; set; }
        public DbSet<NotableWorkEntity> NotableWorks { get; set; }
        public DbSet<SpacePlanetoidEntity> Planetoids { get; set; }
        public DbSet<SpaceCraftCrew> SpaceCraftCrews { get; set; }
        public DbSet<SpaceCraftEntity> SpaceCrafts { get; set; }
        public DbSet<BaseSpaceEntity> SpaceEntities { get; set; }
        public DbSet<UserComment> UserComments { get; set; }

        #endregion Properties

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpaceCraftCrew>()
                .ToTable("SpaceCraftCrews")
                .HasKey(ag => new { ag.AstronautId, ag.SpaceCraftId });

            modelBuilder.Entity<SpaceCraftCrew>()
                .HasOne(scc => scc.SpaceCraft)
                .WithMany(a => a.SpaceCraftCrews)
                .HasForeignKey(scc => scc.SpaceCraftId);

            modelBuilder.Entity<SpaceCraftCrew>()
                .HasOne(scc => scc.Astronaut)
                .WithMany(a => a.SpaceCraftCrews)
                .HasForeignKey(scc => scc.AstronautId);

            modelBuilder.Entity<AstronomerEntity>()
                .HasMany(ae => ae.NotableWorks)
                .WithOne(nw => nw.Astronomer);

            modelBuilder.Entity<SpacePlanetoidEntity>()
                .HasMany(spe => spe.Compositions)
                .WithOne(c => c.Planetoid);

            modelBuilder.Entity<FavoriteUserObject>()
                .ToTable("FavoriteUserObjects")
                .HasKey(fuo => new { fuo.UserId, fuo.SpaceObjectId });

            modelBuilder.Entity<FavoriteUserObject>()
                .HasOne(fuo => fuo.User)
                .WithMany(o => o.FavoriteUserObjects)
                .HasForeignKey(fuo => fuo.UserId);

            modelBuilder.Entity<FavoriteUserObject>()
                .HasOne(fuo => fuo.SpaceObject)
                .WithMany(o => o.FavoriteUserObjects)
                .HasForeignKey(fuo => fuo.SpaceObjectId);

            ApplicationRoleSeeder.Seed(modelBuilder);
            ApplicationUserSeeder.Seed(modelBuilder);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "47b4def6-770c-4df9-ab97-c010904574a6", //Admin role
                UserId = "22c71128-83a4-4f4f-bdcb-7a4ac4ede03c" //Orbital Main account
            }
            , new IdentityUserRole<string>()
            {
                RoleId = "db2ad43a-9f3f-45fd-8b28-068dbc58b799", //MemberRole
                UserId = "ced8f1e3-fbab-4db1-99a1-fa45b1428c21" //Recruit Chuncky
            });

            AstronautSeeder.Seed(modelBuilder);
            AstronomerSeeder.Seed(modelBuilder);
            DebrisSeeder.Seed(modelBuilder);
            NotableWorkSeeder.Seed(modelBuilder);
            PlanetoidSeeder.Seed(modelBuilder);
            PlanetoidComposistionSeeder.Seed(modelBuilder);
            SpaceCraftSeeder.Seed(modelBuilder);
            ImagesSeeder.Seed(modelBuilder);
            FavoriteUserObjectSeeder.Seed(modelBuilder);
            SpaceCraftCrewSeeder.Seed(modelBuilder);
            UserCommentSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        #endregion Methods
    }
}