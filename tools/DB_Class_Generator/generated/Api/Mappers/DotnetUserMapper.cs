using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class DotnetUserMapper : Profile {
        public DotnetUserMapper() {
            CreateMap<DotnetUser, DotnetUserDisplayDto>();
            CreateMap<DotnetUserCreateDto, DotnetUser>();
            CreateMap<DotnetUserUpdateDto, DotnetUser>();
            CreateMap<DotnetUserGetDto, DotnetUser>();
        }
    }
}