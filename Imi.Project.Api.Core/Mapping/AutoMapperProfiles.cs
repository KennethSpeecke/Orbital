using AutoMapper;
using Imi.Project.Api.Core.Dtos.RequestDtos.Scientists;
using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Dtos.ResponseDtos.ApplicationUsers;
using Imi.Project.Api.Core.Dtos.ResponseDtos.Scientists;
using Imi.Project.Api.Core.Dtos.ResponseDtos.SpaceObjects;
using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Entities.Scientists;
using Imi.Project.Api.Core.Entities.SpaceObjects;
using Imi.Project.Api.Core.Extensions.Formatters;
using System.Linq;

namespace Imi.Project.Api.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        #region Constructors

        public AutoMapperProfiles()
        {
            #region Planetoids Mapping Configurations

            //Planetoid Mapping configurations
            CreateMap<SpacePlanetoidEntity, PlanetoidResponseDto>()
                .ForMember(dest => dest.Composition,
                opt => opt.MapFrom(src => PlanetoidCompositionsFormatterExtension.FormatCompositionCollectionToString(src)));

            CreateMap<PlanetoidRequestDto, SpacePlanetoidEntity>()
            .ForMember(dest => dest.Compositions,
            opt => opt.MapFrom(src => src.Compositions
            .Select(pc => new PlanetoidCompositionRequestDto
            {
                Id = pc.Id,
                CompositionType = pc.CompositionType
            })))
            .ForMember(dest => dest.ThumbnailImage,
            opt => opt.MapFrom(src => src.ThumbnailImage));

            #endregion Planetoids Mapping Configurations

            #region Debris Mapping Configurations

            //Debris Mapping Configurations
            CreateMap<SpaceDebrisEntity, DebrisResponseDto>();
            CreateMap<DebrisRequestDto, SpaceDebrisEntity>();

            #endregion Debris Mapping Configurations

            #region SpaceCrafts Mapping Configurations

            //SpaceCraft Mapping Configurations
            CreateMap<SpaceCraftEntity, SpaceCraftResponseDto>()
                .ForMember(dest => dest.SpaceCrews,
                opt => opt.MapFrom(src => src.SpaceCraftCrews
                .Select(scc => new SpaceCrewResponseDto
                {
                    Id = scc.Astronaut.Id,
                    AstronautName = scc.Astronaut.Name,
                    AstronautSurName = scc.Astronaut.Surname
                })));

            #endregion SpaceCrafts Mapping Configurations

            #region Astronaut Mapping Configurations

            //Entity To ResponseDto
            CreateMap<AstronautEntity, AstronautResponseDto>()
                .ForMember(dest => dest.MemberOfAmountOfSpaceCrews,
                opt => opt.MapFrom(src => src.SpaceCraftCrews.Count()));

            //Request Dto to Entity
            CreateMap<AstronautRequestDto, AstronautEntity>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id));

            #endregion Astronaut Mapping Configurations

            #region Astronomer Mapping Configurations

            //Astronomer entity => Astronomer Response Dto
            CreateMap<AstronomerEntity, AstronomerResponseDto>()
                .ForMember(dest => dest.AmountOfNotableWorks,
                opt => opt.MapFrom(src => src.NotableWorks.Count()));

            CreateMap<AstronomerRequestDto, AstronomerEntity>();

            #endregion Astronomer Mapping Configurations

            #region NotableWorks Mapping Configurations

            //Notable Works Entity => Notable work Response Dto
            CreateMap<NotableWorkEntity, NotableWorkResponseDto>()
                .ForMember(dest => dest.AstronomerName,
                     opt => opt.MapFrom(src => src.Astronomer.Name))
                .ForMember(dest => dest.AstronomerSurname,
                    opt => opt.MapFrom(src => src.Astronomer.Surname))
                .ForMember(dest => dest.AstronomerId,
                    opt => opt.MapFrom(src => src.AstronomerId));

            //NotableWorks RequestDto => Entity
            CreateMap<NotableWorkRequestDto, NotableWorkEntity>();

            #endregion NotableWorks Mapping Configurations

            #region Application Users Mapping Configurations

            //Application User entity =>  Application User Response Dto
            CreateMap<ApplicationUser, ApplicationUserResponseDto>()
                .ForMember(dest => dest.ApplicationUserComments,
                opt => opt.MapFrom(src => src.UserComments
                .Select(uc => new ApplicationUserCommentResponseDto
                {
                    Id = uc.Id,
                    Text = uc.Text
                })));

            #endregion Application Users Mapping Configurations
        }

        #endregion Constructors
    }
}