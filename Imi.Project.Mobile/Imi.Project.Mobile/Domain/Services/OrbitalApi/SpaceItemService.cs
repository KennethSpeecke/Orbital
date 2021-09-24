using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Base;
using Imi.Project.Mobile.Domain.Models.Enums;
using Imi.Project.Mobile.Domain.Models.SpaceObjects;
using Imi.Project.Mobile.Extensions;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.OrbitalApi
{
    public class SpaceItemService : ISpaceItemService<SpaceBaseItemViewModel<Guid>>
    {
        #region Fields

        private readonly string _baseApiConnectionUri;

        #endregion Fields

        #region Constructors

        public SpaceItemService()
        {
            _baseApiConnectionUri = "https://192.168.0.245:5001/";
        }

        #endregion Constructors

        #region Methods

        public Task<SpaceBaseItemViewModel<Guid>> AddAsync(SpaceBaseItemViewModel<Guid> item)
        {
            throw new NotImplementedException();
        }

        public Task<SpaceBaseItemViewModel<Guid>> DeleteAsync(SpaceBaseItemViewModel<Guid> item)
        {
            throw new NotImplementedException();
        }

        public Task<SpaceBaseItemViewModel<Guid>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SpaceBaseItemViewModel<Guid>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SpaceBaseItemViewModel<Guid>>> GetAllTrackableAsync()
        {
            var planetoids = await WebApiClient.GetApiResult<IEnumerable<SpaceBaseItemViewModel<Guid>>>($"{_baseApiConnectionUri}api/planetoids");
            var debris = await WebApiClient.GetApiResult<IEnumerable<SpaceBaseItemViewModel<Guid>>>($"{_baseApiConnectionUri}api/debris");
            var mannedcrafts = await WebApiClient.GetApiResult<IEnumerable<SpaceBaseItemViewModel<Guid>>>($"{_baseApiConnectionUri}api/spacecrafts/isMannedCraft?isMannedCraft=true");
            var unmannedcrafts = await WebApiClient.GetApiResult<IEnumerable<SpaceBaseItemViewModel<Guid>>>($"{_baseApiConnectionUri}api/spacecrafts/isMannedCraft?isMannedCraft=false");

            var allItems = planetoids.Where(p => p.Apogee != 0 && p.Perigee != 0).ToList();
            allItems.AddRange(debris.Where(d => d.Apogee != 0 && d.Perigee != 0).ToList());
            allItems.AddRange(mannedcrafts.Where(mc => mc.Apogee != 0 && mc.Perigee != 0).ToList());
            allItems.AddRange(unmannedcrafts.Where(umc => umc.Apogee != 0 && umc.Perigee != 0).ToList());
            return allItems;
        }

        public async Task<SpaceBaseItemViewModel<Guid>> GetByIdAsync(Guid id)
        {
            return await WebApiClient.GetApiResult<SpaceBaseItemViewModel<Guid>>($"{_baseApiConnectionUri}api/");
        }

        public Task<SpaceBaseItemViewModel<Guid>> GetByIdAsync(Guid id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public async Task<SpaceBaseItemViewModel<Guid>> GetByIdAsync(Guid id, SpaceItemTypes spaceItemType)
        {
            switch (spaceItemType)
            {
                case SpaceItemTypes.DEBRIS:
                    return await WebApiClient.GetApiResult<SpaceBaseItemViewModel<Guid>>($"{_baseApiConnectionUri}api/debris/{id}");

                case SpaceItemTypes.PLANETOID:
                    return await WebApiClient.GetApiResult<SpaceBaseItemViewModel<Guid>>($"{_baseApiConnectionUri}api/planetoids/{id}");

                case SpaceItemTypes.MANNEDCRAFT:
                    return await WebApiClient.GetApiResult<SpaceBaseItemViewModel<Guid>>($"{_baseApiConnectionUri}api/{id}/true");

                case SpaceItemTypes.UNMANNEDCRAFT:
                    return await WebApiClient.GetApiResult<SpaceBaseItemViewModel<Guid>>($"{_baseApiConnectionUri}api/spacecraft?id={id}&ismannedcraft=false");

                default:
                    return await Task.FromResult(new SpaceBaseItemViewModel<Guid>());
            }
        }

        public async Task<IEnumerable<SpaceBaseItemViewModel<Guid>>> GetSpaceItemsByType(SpaceItemTypes spaceItemType)
        {
            List<SpaceBaseItemViewModel<Guid>> spaceItems = new List<SpaceBaseItemViewModel<Guid>>();
            IEnumerable<BaseSpaceItemModel<Guid>> apiResult;

            switch (spaceItemType)
            {
                case SpaceItemTypes.DEBRIS:
                    apiResult = await WebApiClient.GetApiResult<IEnumerable<DebrisModel>>($"{_baseApiConnectionUri}api/debris");
                    foreach (var item in (IEnumerable<DebrisModel>)apiResult)
                    {
                        spaceItems.Add(new DebrisItemViewModel
                        {
                            Id = item.Id,
                            Apogee = item.Apogee,
                            ImageUris = item.ImageUrls,
                            Mass = item.Mass.ToString(),
                            Size = item.Size.ToString(),
                            IsOnCollisionCourse = BoolToAdverbialConverterExtension.ConvertBoolToString(item.IsOnCollisionCourse),
                            Name = item.Name,
                            ShortName = item.ShortName,
                            SpaceType = spaceItemType.ToString(),
                            Perigee = item.Perigee,
                            ThumbnailImageUri = ImageBindingHandlerExtension.CheckIfImageIsValid(item.ThumbnailImage)
                        });
                    }

                    break;

                case SpaceItemTypes.PLANETOID:
                    apiResult = await WebApiClient.GetApiResult<IEnumerable<PlanetoidModel>>($"{_baseApiConnectionUri}api/planetoids");
                    foreach (var item in (IEnumerable<PlanetoidModel>)apiResult)
                    {
                        spaceItems.Add(new PlanetoidItemViewModel
                        {
                            Id = item.Id,
                            Apogee = item.Apogee,
                            ImageUris = item.ImageUrls,
                            Mass = item.Mass.ToString(),
                            Size = item.Size.ToString(),
                            Name = item.Name,
                            ShortName = item.ShortName,
                            SpaceType = spaceItemType.ToString(),
                            Perigee = item.Perigee,
                            ThumbnailImageUri = ImageBindingHandlerExtension.CheckIfImageIsValid(item.ThumbnailImage),
                            Composition = item.Composition,
                            DiscovererName = $"N/A",
                            Shape = item.Shape
                        });
                    }

                    break;

                case SpaceItemTypes.MANNEDCRAFT:
                    apiResult = await WebApiClient.GetApiResult<IEnumerable<SpaceCraftModel>>($"{_baseApiConnectionUri}api/SpaceCrafts/isMannedCraft?isMannedCraft=true");
                    foreach (var item in (IEnumerable<SpaceCraftModel>)apiResult)
                    {
                        spaceItems.Add(new SpaceCraftItemViewModel
                        {
                            Id = item.Id,
                            Apogee = item.Apogee,
                            ImageUris = item.ImageUrls,
                            Mass = item.Mass.ToString(),
                            Size = item.Size.ToString(),
                            Name = item.Name,
                            ShortName = item.ShortName,
                            SpaceType = spaceItemType.ToString(),
                            Perigee = item.Perigee,
                            ThumbnailImageUri = ImageBindingHandlerExtension.CheckIfImageIsValid(item.ThumbnailImage),
                            MissionInformation = item.MissionInformation
                        });
                    }
                    break;

                case SpaceItemTypes.UNMANNEDCRAFT:
                    apiResult = await WebApiClient.GetApiResult<IEnumerable<SpaceCraftModel>>($"{_baseApiConnectionUri}api/SpaceCrafts/isMannedCraft?isMannedCraft=false");
                    foreach (var item in (IEnumerable<SpaceCraftModel>)apiResult)
                    {
                        spaceItems.Add(new SpaceCraftItemViewModel
                        {
                            Id = item.Id,
                            Apogee = item.Apogee,
                            ImageUris = item.ImageUrls,
                            Mass = item.Mass.ToString(),
                            Size = item.Size.ToString(),
                            Name = item.Name,
                            ShortName = item.ShortName,
                            SpaceType = spaceItemType.ToString(),
                            Perigee = item.Perigee,
                            ThumbnailImageUri = ImageBindingHandlerExtension.CheckIfImageIsValid(item.ThumbnailImage),
                            MissionInformation = item.MissionInformation
                        });
                    }
                    break;

                default:
                    spaceItems = new List<SpaceBaseItemViewModel<Guid>>();
                    break;
            }

            return spaceItems.AsEnumerable();
        }

        public async Task<SpaceBaseItemViewModel<Guid>> UpdateAsync(SpaceBaseItemViewModel<Guid> item)
        {
            switch (item.SpaceType)
            {
                case nameof(SpaceItemTypes.DEBRIS):
                    var updatedDebrisItem = new DebrisModel()
                    {
                        Id = item.Id,
                        Apogee = item.Apogee,
                        Perigee = item.Perigee,
                        Mass = double.Parse(item.Mass),
                        Name = item.Name,
                        ShortName = item.ShortName,
                        Size = double.Parse(item.Size),
                        SpaceItemType = SpaceItemTypes.DEBRIS,
                        //IsOnCollisionCourse = BoolToAdverbialConverterExtension.ConvertStringAdverbialToBool(((DebrisItemViewModel)item).IsOnCollisionCourse),
                        //ThumbnailImage = ImageBindingHandlerExtension.CheckIfImageIsValid(item.ThumbnailImageUri.AbsoluteUri ?? "default").ToString()
                    };

                    if (updatedDebrisItem.ThumbnailImage != null)
                        updatedDebrisItem.ThumbnailImage = item.ThumbnailImageUri.LocalPath;

                    await WebApiClient.PutCallApi<DebrisItemViewModel, DebrisModel>($"{_baseApiConnectionUri}api/debris", updatedDebrisItem);
                    return item;

                case nameof(SpaceItemTypes.PLANETOID):
                    var updatedPlanetoidItem = new PlanetoidModel()
                    {
                        Id = item.Id,
                        Apogee = item.Apogee,
                        Mass = double.Parse(item.Mass),
                        Size = double.Parse(item.Size),
                        Name = item.Name,
                        ShortName = item.ShortName,
                        Perigee = item.Perigee,
                        SpaceItemType = SpaceItemTypes.PLANETOID,
                    };
                    await WebApiClient.PutCallApi<PlanetoidItemViewModel, PlanetoidModel>($"{_baseApiConnectionUri}api/planetoids", updatedPlanetoidItem);
                    return item;

                case nameof(SpaceItemTypes.UNMANNEDCRAFT):
                    var updatedUnamnnedItem = new SpaceCraftModel()
                    {
                        Id = item.Id,
                        Apogee = item.Apogee,
                        Mass = double.Parse(item.Mass),
                        Size = double.Parse(item.Size),
                        Name = item.Name,
                        ShortName = item.ShortName,
                        Perigee = item.Perigee,
                        SpaceItemType = SpaceItemTypes.UNMANNEDCRAFT,
                    };
                    await WebApiClient.PutCallApi<SpaceCraftItemViewModel, SpaceCraftModel>($"{_baseApiConnectionUri}api/spacecrafts", updatedUnamnnedItem);
                    return item;

                case nameof(SpaceItemTypes.MANNEDCRAFT):
                    var updatedMannedItem = new SpaceCraftModel()
                    {
                        Id = item.Id,
                        Apogee = item.Apogee,
                        Mass = double.Parse(item.Mass),
                        Size = double.Parse(item.Size),
                        Name = item.Name,
                        ShortName = item.ShortName,
                        Perigee = item.Perigee,
                        SpaceItemType = SpaceItemTypes.MANNEDCRAFT,
                    };
                    await WebApiClient.PutCallApi<SpaceCraftItemViewModel, SpaceCraftModel>($"{_baseApiConnectionUri}api/spacecrafts", updatedMannedItem);
                    return item;

                default:
                    return item;
            }
        }

        #endregion Methods
    }
}