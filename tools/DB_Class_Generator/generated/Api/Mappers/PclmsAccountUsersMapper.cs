using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsAccountUsersMapper : Profile {
        public PclmsAccountUsersMapper() {
            CreateMap<PclmsAccountUsers, PclmsAccountUsersDisplayDto>();
            CreateMap<PclmsAccountUsersCreateDto, PclmsAccountUsers>();
            CreateMap<PclmsAccountUsersUpdateDto, PclmsAccountUsers>();
            CreateMap<PclmsAccountUsersGetDto, PclmsAccountUsers>();
        }
    }
}