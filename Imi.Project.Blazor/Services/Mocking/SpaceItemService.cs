using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Enums;
using Imi.Project.Blazor.Models.Scientists;
using Imi.Project.Blazor.Models.SpaceObjects;
using Imi.Project.Blazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Mocking
{
    public class SpaceItemService : ICrudService<BaseSpaceItem<Guid>>
    {
        #region Fields

        private const string criticalErrorMessage = "Critical Error. Contact a developer!";
        private const string itemNotFoundErrorMessage = "Item was not found, Does it even exist?";

        #endregion Fields

        #region Temporary static test data until storage provider is ready...

        private static List<SpaceCraftModel> craftsCollection = new List<SpaceCraftModel>
        {
            new SpaceCraftModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                Name = "Starlink V1 L4",
                ShortName = "SLC-40",
                Apogee = 550,
                Perigee = 550,
                Mass = 260,
                MissionInformation = "Starlink is SpaceX's 12000-satellite low earth orbit constellation to provide broadband Internet access.",
                Size = 2,
                SpaceItemType = SpaceItemTypes.UNMANNEDCRAFT,
                IsFavorite = false,
                ImageUrls = new List<string>{ "images/StarlinkSatelite.jpg"}
            },

            new SpaceCraftModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                Name = "Crew Dragon",
                ShortName = "C-DA",
                Apogee = 0,
                Perigee = 0,
                Mass = 9616,
                MissionInformation = "Crew dragon created by spacex is designed to send humans to the Iss and back to earth in a costeffective manner.",
                Size = 8,
                SpaceItemType = SpaceItemTypes.MANNEDCRAFT,
                IsFavorite = false,
                ImageUrls = new List<string>{"images/CrewDragonRCapsule.jpg" }
            },
        };

        private static ICollection<DebrisModel> debrisCollection = new List<DebrisModel>
        {
            new DebrisModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Name = "Cosmos 2251",
                ShortName = "1993-036BXZ",
                Apogee = 760,
                Perigee = 736,
                IsOnCollisionCourseWithEarth = false,
                Mass = 15437.15,
                Size = 12,
                SpaceItemType = SpaceItemTypes.DEBRIS,
                IsFavorite = false,
                ImageUrls = new List<string>{ "images/Cosmos2251.jpg"}
            },

            new DebrisModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                Name = "Iridium 33",
                ShortName = "1997-051DG",
                Apogee = 899,
                Perigee = 756,
                IsOnCollisionCourseWithEarth = true,
                Mass = 241,
                Size = 1,
                SpaceItemType = SpaceItemTypes.DEBRIS,
                IsFavorite = false,
                ImageUrls = new List<string>{ "images/Iridium33.jpg"}
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

        private static List<PlanetoidModel> planetoidCollection = new List<PlanetoidModel>
        {
            new PlanetoidModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                Name = "Hydra",
                ShortName = "S/2005",
                Apogee = 38,
                Perigee = 38,
                Compossision = new List<PlanetoidCompositions>{PlanetoidCompositions.SOLID, PlanetoidCompositions.LIQUID},
                Discoverer = galileo,
                Mass = 4877,
                Shape = "Sphere",
                Size = 5752,
                SpaceItemType = SpaceItemTypes.PLANETOID,
                IsFavorite = false,
                ImageUrls = new List<string>{ "images/HydraPlanetoid.jpg"}
            },

            new PlanetoidModel
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                Name = "Kerberos",
                ShortName = "S/2011",
                Apogee = 32,
                Perigee = 31,
                Compossision = new List<PlanetoidCompositions>{PlanetoidCompositions.SOLID},
                Discoverer = galileo,
                Mass = 1676,
                Shape = "Oval",
                Size = 1710,
                SpaceItemType = SpaceItemTypes.PLANETOID,
                IsFavorite = false,
                ImageUrls = new List<string>{ "images/kerberosPlanetoid.jpg"}
            },
        };

        #endregion Temporary static test data until storage provider is ready...

        #region Methods

        public async Task<BaseSpaceItem<Guid>> Create(BaseSpaceItem<Guid> itemToCreate)
        {
            //And for the love of god refactor this switch statement so it isnt a spaghett mess....
            //Use a dictionary or something?? Dict<nameof(Property), (Enum value)>??
            //Will rewrite this when api is finished so we dont have to worry about static data.... Using a separated service that fetches data will be a cleaner implementation.

            try
            {
                var itemType = itemToCreate.SpaceItemType;

                switch (itemType)
                {
                    case SpaceItemTypes.DEBRIS:
                        debrisCollection.Add(new DebrisModel
                        {
                            Id = Guid.NewGuid(),
                            Name = itemToCreate.Name,
                            ShortName = itemToCreate.ShortName,
                            Apogee = itemToCreate.Apogee,
                            Perigee = itemToCreate.Perigee,
                            SpaceItemType = itemToCreate.SpaceItemType,
                            Size = itemToCreate.Size,
                            Mass = itemToCreate.Mass,
                            Latitude = itemToCreate.Latitude,
                            Longtitude = itemToCreate.Longtitude,
                            ImageUrls = itemToCreate.ImageUrls,
                            IsFavorite = itemToCreate.IsFavorite,
                            IsOnCollisionCourseWithEarth = ((DebrisModel)itemToCreate).IsOnCollisionCourseWithEarth
                        });
                        break;

                    case SpaceItemTypes.PLANETOID:
                        planetoidCollection.Add(new PlanetoidModel
                        {
                            Id = Guid.NewGuid(),
                            Name = itemToCreate.Name,
                            ShortName = itemToCreate.ShortName,
                            Apogee = itemToCreate.Apogee,
                            Perigee = itemToCreate.Perigee,
                            SpaceItemType = itemToCreate.SpaceItemType,
                            Size = itemToCreate.Size,
                            Mass = itemToCreate.Mass,
                            Latitude = itemToCreate.Latitude,
                            Longtitude = itemToCreate.Longtitude,
                            ImageUrls = itemToCreate.ImageUrls,
                            IsFavorite = itemToCreate.IsFavorite,
                            Compossision = ((PlanetoidModel)itemToCreate).Compossision,
                            Discoverer = ((PlanetoidModel)itemToCreate).Discoverer,
                            Shape = ((PlanetoidModel)itemToCreate).Shape
                        });
                        break;

                    case SpaceItemTypes.MANNEDCRAFT:
                        craftsCollection.Add(new SpaceCraftModel
                        {
                            Id = Guid.NewGuid(),
                            Name = itemToCreate.Name,
                            ShortName = itemToCreate.ShortName,
                            Apogee = itemToCreate.Apogee,
                            Perigee = itemToCreate.Perigee,
                            SpaceItemType = itemToCreate.SpaceItemType,
                            Size = itemToCreate.Size,
                            Mass = itemToCreate.Mass,
                            Latitude = itemToCreate.Latitude,
                            Longtitude = itemToCreate.Longtitude,
                            ImageUrls = itemToCreate.ImageUrls,
                            IsFavorite = itemToCreate.IsFavorite,
                            MissionInformation = ((SpaceCraftModel)itemToCreate).MissionInformation
                        });
                        break;

                    case SpaceItemTypes.UNMANNEDCRAFT:
                        craftsCollection.Add(new SpaceCraftModel
                        {
                            Id = Guid.NewGuid(),
                            Name = itemToCreate.Name,
                            ShortName = itemToCreate.ShortName,
                            Apogee = itemToCreate.Apogee,
                            Perigee = itemToCreate.Perigee,
                            SpaceItemType = itemToCreate.SpaceItemType,
                            Size = itemToCreate.Size,
                            Mass = itemToCreate.Mass,
                            Latitude = itemToCreate.Latitude,
                            Longtitude = itemToCreate.Longtitude,
                            ImageUrls = itemToCreate.ImageUrls,
                            IsFavorite = itemToCreate.IsFavorite,
                            MissionInformation = ((SpaceCraftModel)itemToCreate).MissionInformation
                        });
                        break;

                    default:
                        Console.WriteLine("Selected spacetype does not exist! This should not be possible!");
                        break;
                }

                return await Task.FromResult(itemToCreate);
            }
            catch (Exception e)
            {
                throw new Exception(criticalErrorMessage, e.InnerException);
            }
        }

        public async Task<BaseSpaceItem<Guid>> Delete(BaseSpaceItem<Guid> itemToDelete)
        {
            try
            {
                var allItems = await GetItemList();
                var foundItemToDelete = allItems.SingleOrDefault(i => i.Id == itemToDelete.Id);

                if (foundItemToDelete == null)
                {
                    throw new ArgumentException(itemNotFoundErrorMessage);
                }

                switch (foundItemToDelete.SpaceItemType)
                {
                    case SpaceItemTypes.DEBRIS:
                        debrisCollection.Remove(itemToDelete as DebrisModel);
                        break;

                    case SpaceItemTypes.PLANETOID:
                        planetoidCollection.Remove(itemToDelete as PlanetoidModel);
                        break;

                    case SpaceItemTypes.MANNEDCRAFT:
                        craftsCollection.Remove(itemToDelete as SpaceCraftModel);
                        break;

                    case SpaceItemTypes.UNMANNEDCRAFT:
                        craftsCollection.Remove(itemToDelete as SpaceCraftModel);
                        break;

                    default:
                        throw new Exception("Uknown error. Contact a developer");
                }

                return await Task.FromResult(itemToDelete);
            }
            catch (Exception e)
            {
                throw new Exception(criticalErrorMessage, e.InnerException);
            }
        }

        public async Task<BaseSpaceItem<Guid>> GetById(Guid id)
        {
            try
            {
                var allItems = await GetItemList();
                var foundItem = allItems.Where(i => i.Id == id).SingleOrDefault();
                if (foundItem == null)
                {
                    throw new ArgumentException("Spaceitem was not found! Does the item exist?");
                }

                return await Task.FromResult(foundItem);
            }
            catch (Exception e)
            {
                throw new Exception(criticalErrorMessage, e.InnerException);
            }
        }

        public async Task<BaseSpaceItem<Guid>[]> GetItemList()
        {
            try
            {
                var itemList = new List<BaseSpaceItem<Guid>>();

                itemList.AddRange(debrisCollection);
                itemList.AddRange(planetoidCollection);
                itemList.AddRange(craftsCollection);

                return await Task.FromResult(itemList.ToArray());
            }
            catch (Exception e)
            {
                throw new Exception(criticalErrorMessage, e.InnerException);
            }
        }

        public async Task<BaseSpaceItem<Guid>[]> GetItemsWithSpaceType(SpaceItemTypes spaceItemType)
        {
            try
            {
                var allItems = await GetItemList();
                var foundItems = allItems.Where(i => i.SpaceItemType == spaceItemType).ToArray();

                return await Task.FromResult(foundItems);
            }
            catch (Exception e)
            {
                throw new Exception(criticalErrorMessage, e.InnerException);
            }
        }

        public async Task<BaseSpaceItem<Guid>[]> GetItemsWithSpaceTypes(ICollection<SpaceItemTypes> spaceItemTypes)
        {
            var allItems = await GetItemList();
            var foundItems = allItems.Where(i => i.SpaceItemType == SpaceItemTypes.MANNEDCRAFT || i.SpaceItemType == SpaceItemTypes.UNMANNEDCRAFT).ToArray();

            return await Task.FromResult(foundItems);
        }

        public Task<BaseSpaceItem<Guid>> GetNewItem()
        {
            throw new NotImplementedException();
        }

        public async Task<BaseSpaceItem<Guid>> Update(BaseSpaceItem<Guid> itemToUpdate)
        {
            try
            {
                var allItems = await GetItemList();
                var foundItemToUpdate = allItems.Where(i => i.Id == itemToUpdate.Id).SingleOrDefault();

                if (foundItemToUpdate == null)
                {
                    throw new Exception("Uknown error, Contact a developer.");
                }

                switch (foundItemToUpdate.SpaceItemType)
                {
                    case SpaceItemTypes.DEBRIS:
                        debrisCollection.Remove(foundItemToUpdate as DebrisModel);
                        foundItemToUpdate = itemToUpdate;
                        debrisCollection.Add(foundItemToUpdate as DebrisModel);
                        break;

                    case SpaceItemTypes.PLANETOID:
                        planetoidCollection.Remove(foundItemToUpdate as PlanetoidModel);
                        foundItemToUpdate = itemToUpdate;
                        planetoidCollection.Add(foundItemToUpdate as PlanetoidModel);
                        break;

                    case SpaceItemTypes.MANNEDCRAFT:
                        craftsCollection.Remove(foundItemToUpdate as SpaceCraftModel);
                        foundItemToUpdate = itemToUpdate;
                        craftsCollection.Add(foundItemToUpdate as SpaceCraftModel);
                        break;

                    case SpaceItemTypes.UNMANNEDCRAFT:
                        craftsCollection.Remove(foundItemToUpdate as SpaceCraftModel);
                        foundItemToUpdate = itemToUpdate;
                        craftsCollection.Add(foundItemToUpdate as SpaceCraftModel);
                        break;

                    default:
                        throw new Exception("Uknown error. Conact a developer");
                }
                return await Task.FromResult(foundItemToUpdate);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message, e.InnerException);
            }
        }

        #endregion Methods
    }
}