using AutoMapper;
using Imi.Project.Mobile.Domain.Models.Base;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;

namespace Imi.Project.Mobile.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        #region Constructors

        public AutoMapperProfiles()
        {
            #region Space Object Mappings

            //Base Pobject Mapping Configurations
            CreateMap<BaseSpaceItemModel<Guid>, SpaceBaseItemViewModel<Guid>>()
                .ForMember(dest => dest.SpaceType,
                opt => opt.MapFrom(src => src.SpaceItemType.ToString()));

            #endregion Space Object Mappings
        }

        #endregion Constructors
    }
}