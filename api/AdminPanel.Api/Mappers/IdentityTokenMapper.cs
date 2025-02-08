using AdminPanel.Api.DTOs;
using AdminPanel.Api.Models;
using AdminPanel.ModelsAndRepository.Models;
using AutoMapper;
namespace AdminPanel.Api.Mappers {
    public class IdentityTokenMapper : Profile{
        public IdentityTokenMapper() {
            CreateMap<RequesterRequest, Token>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Sub))
                .ForMember(dest => dest.Expires_At, opt => opt.MapFrom(src => src.Exp))
                .ForMember(dest => dest.User_Id, opt => opt.MapFrom(src => src.Uid));
            CreateMap<Token, RequesterRequest>()
                .ForMember(dest => dest.Sub, opt => opt.MapFrom(src => src.ClientId))
                .ForMember(dest => dest.Exp, opt => opt.MapFrom(src => src.Expires_At))
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => src.User_Id));

            CreateMap<Token, CreateFakeToken>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.ClientId))
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => src.User_Id))
                .ForMember(dest => dest.Expires_At, opt => opt.MapFrom(src => src.Expires_At));
            CreateMap<CreateFakeToken,Token>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.ClientId))
                .ForMember(dest => dest.User_Id, opt => opt.MapFrom(src => src.Uid))
                .ForMember(dest => dest.Expires_At, opt => opt.MapFrom(src => src.Expires_At));

        }
    }
}
