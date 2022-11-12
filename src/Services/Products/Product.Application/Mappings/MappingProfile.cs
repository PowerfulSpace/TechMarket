using AutoMapper;
using Product.Application.DTOs.PhonesAndGadgets.HeadphonesDTOs;
using Product.Application.DTOs.PhonesAndGadgets.PhoneDTOs;
using Product.Application.DTOs.PhonesAndGadgets.SmartWatchDTOs;
using Product.Application.DTOs.TV.ProjectionScreenDTOs;
using Product.Application.DTOs.TV.ProjectorDTOs;
using Product.Application.DTOs.TV.TVDTOs;
using Product.Domain.Electronics.PhonesAndGadgets;
using Product.Domain.Electronics.TV;
using Headphones = Product.Domain.Electronics.PhonesAndGadgets.Headphone;
using Game = Product.Domain.Electronics.VideoGames.Games;
using Product.Application.DTOs.VideoGames.GameDTOs;
using Product.Domain.Electronics.VideoGames;
using Product.Application.DTOs.VideoGames.GamepadDTOs;
using Product.Application.DTOs.VideoGames.PlayStationDTOs;

namespace Product.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Headphones
            CreateMap<Headphones, HeadphonesDto>();
            CreateMap<CreateHeadphonesDto, Headphones>();
            CreateMap<UpdateHeadphonesDto, Headphones>();
            // Phone
            CreateMap<Phone, PhoneDto>();
            CreateMap<CreatePhoneDto, Phone>();
            CreateMap<UpdatePhoneDto, Phone>();
            // SmartWatch
            CreateMap<SmartWatch, SmartWatchDto>();
            CreateMap<CreateSmartWatchDto, SmartWatch>();
            CreateMap<UpdateSmartWatchDto, SmartWatch>();
            // ProjectionScreen
            CreateMap<ProjectionScreen, ProjectionScreenDto>();
            CreateMap<CreateProjectionScreenDto, ProjectionScreen>();
            CreateMap<UpdateProjectionScreenDto, ProjectionScreen>();
            // Projector
            CreateMap<Projector, ProjectorDto>();
            CreateMap<CreateProjectorDto, Projector>();
            CreateMap<UpdateProjectorDto, Projector>();
            // TV
            CreateMap<TV, TVDto>();
            CreateMap<CreateTVDto, TV>();
            CreateMap<UpdateTVDto, TV>();
            // Game
            CreateMap<Game, GameDto>();
            CreateMap<CreateGameDto, Game>();
            CreateMap<UpdateGameDto, Game>();
            // Gamepad
            CreateMap<Gamepad, GamepadDto>();
            CreateMap<CreateGamepadDto, Gamepad>();
            CreateMap<UpdateGamepadDto, Gamepad>();
            // PlayStation
            CreateMap<PlayStation, PlayStationDto>();
            CreateMap<CreatePlayStationDto, PlayStation>();
            CreateMap<UpdatePlayStationDto, PlayStation>();
        }
    }
}
