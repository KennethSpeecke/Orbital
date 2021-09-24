using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Enums;
using Imi.Project.Mobile.Domain.Models.Scientists;
using Imi.Project.Mobile.Extensions;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockSpaceItemService<T> : ISpaceItemService<T> where T : SpaceBaseItemViewModel<Guid>
    {
        #region Temporary static test data until storage provider is ready...

        private static List<SpaceCraftItemViewModel> craftsCollection = new List<SpaceCraftItemViewModel>
        {
            new SpaceCraftItemViewModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                Name = "Starlink V1 L4",
                ShortName = "SLC-40",
                Apogee = 550,
                Perigee = 550,
                Mass = "260",
                MissionInformation = "Starlink is SpaceX's 12000-satellite low earth orbit constellation to provide broadband Internet access.",
                Size = "2",
                SpaceType = SpaceItemTypes.UNMANNEDCRAFT.ToString(),
                ImageUris = new List<string>{ "StarlinkSatelite.jpg"}
            },

            new SpaceCraftItemViewModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                Name = "Crew Dragon",
                ShortName = "C-DA",
                Apogee = 0,
                Perigee = 0,
                Mass = "9616",
                MissionInformation = "Crew dragon created by spacex is designed to send humans to the Iss and back to earth in a costeffective manner.",
                Size = "8",
                SpaceType = SpaceItemTypes.MANNEDCRAFT.ToString(),
                ImageUris = new List<string>{ "CrewDragonRCapsule.jpg"}
            },
        };

        private static ICollection<DebrisItemViewModel> debrisCollection = new List<DebrisItemViewModel>
        {
            new DebrisItemViewModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Name = "Cosmos 2251",
                ShortName = "1993-036BXZ",
                Apogee = 760,
                Perigee = 736,
                IsOnCollisionCourse = BoolToAdverbialConverterExtension.ConvertBoolToString(false),
                Mass = "15437.15",
                Size = "12",
                SpaceType = SpaceItemTypes.DEBRIS.ToString(),
                ImageUris = new List<string>{ "Cosmos2251.jpg"}
            },

            new DebrisItemViewModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                Name = "Iridium 33",
                ShortName = "1997-051DG",
                Apogee = 899,
                Perigee = 756,
                IsOnCollisionCourse = BoolToAdverbialConverterExtension.ConvertBoolToString(true),
                Mass = "241",
                Size = "1",
                SpaceType = SpaceItemTypes.DEBRIS.ToString(),
                ImageUris = new List<string>{ "Iridium33.jpg"}
            },
        };

        private static AstronomerModel galileo = new AstronomerModel
        {
            Id = Guid.Parse("00000000-1111-0000-0000-000000000000"),
            Name = "Galileo",
            Surname = "Galilei",
            Age = 78,
            BirthDate = DateTime.Parse("Feb 15, 1564"),
            ObitDate = DateTime.Parse("Jan 8, 1642"),
            NotableWorks = new List<string> { "Invented the telescope", "Invented mechanics" },
            TotalActiveWorkingYears = 52,
            TotalDiscoveriesMade = 13
        };

        private static AstronautModel neilArmstrong = new AstronautModel
        {
            Id = Guid.Parse("00000001-0000-0000-0000-000000000000"),
            Name = "Neil",
            Surname = "Alden Armstrong",
            Age = 82,
            BirthDate = DateTime.Parse("Aug 5, 1930"),
            ObitDate = DateTime.Parse("Aug 25, 2012"),
            IsCurrentlyActiveInSpace = false,
            TimeInSpace = DateTime.MinValue.AddDays(8).AddHours(14).AddMinutes(12).AddSeconds(30),
            TimeServedForMilitary = DateTime.MinValue.AddYears(21),
            TotalMissions = 79,
            Crews = new List<string> { "Gemini 8", "Gemini 11", "Apollo 11" }
        };

        private static List<PlanetoidItemViewModel> planetoidCollection = new List<PlanetoidItemViewModel>
        {
            new PlanetoidItemViewModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                Name = "Hydra",
                ShortName = "S/2005",
                Apogee = 38,
                Perigee = 38,
                Composition = $"{PlanetoidCompositions.SOLID.ToString() + PlanetoidCompositions.LIQUID.ToString()}",
                DiscovererName = "galileo",
                Mass = "4877",
                Shape = "Oval",
                Size = "5752",
                SpaceType = SpaceItemTypes.PLANETOID.ToString(),
                ImageUris = new List<string>{ "HydraPlanetoid.jpg"}
            },

            new PlanetoidItemViewModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                Name = "Kerberos",
                ShortName = "S/2011",
                Apogee = 32,
                Perigee = 31,
                Composition = $"{PlanetoidCompositions.SOLID}",
                DiscovererName = "galileo",
                Mass = "1676",
                Shape = "Sphere",
                Size = "1710",
                SpaceType = SpaceItemTypes.PLANETOID.ToString(),
                ImageUris = new List<string>{ "KerberosPlanetoid.jpg"}
            },
        };

        #endregion Temporary static test data until storage provider is ready...

        #region Methods

        public Task<T> AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var allItems = new List<SpaceBaseItemViewModel<Guid>>();

                allItems.AddRange(debrisCollection);
                allItems.AddRange(planetoidCollection);
                allItems.AddRange(craftsCollection);

                return (IEnumerable<T>)await Task.FromResult(allItems);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} - {e.InnerException}");

                throw new Exception(e.Message, e.InnerException);
            }
        }

        public async Task<IQueryable<T>> GetAllCraftsAsync()
        {
            return (IQueryable<T>)await Task.FromResult(craftsCollection);
        }

        public async Task<IQueryable<T>> GetAllDebrisAsync()
        {
            return (IQueryable<T>)await Task.FromResult(debrisCollection);
        }

        public async Task<IQueryable<T>> GetAllPlantoidsAsync()
        {
            return (IQueryable<T>)await Task.FromResult(planetoidCollection);
        }

        public Task<IEnumerable<T>> GetAllTrackableAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var allSpaceItems = new List<SpaceBaseItemViewModel<Guid>>();

            allSpaceItems.AddRange(debrisCollection);
            allSpaceItems.AddRange(planetoidCollection);
            allSpaceItems.AddRange(craftsCollection);

            var foundItem = allSpaceItems.FirstOrDefault(fi => fi.Id.Equals(id));

            return (T)await Task.FromResult(foundItem);
        }

        public Task<T> GetByIdAsync(Guid id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id, SpaceItemTypes spaceItemType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetSpaceItemsByType(SpaceItemTypes spaceItemType)
        {
            var allItems = await GetAllAsync();
            var foundItems = allItems.Where(i => i.SpaceType.Equals(spaceItemType));

            return await Task.FromResult(foundItems);
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}