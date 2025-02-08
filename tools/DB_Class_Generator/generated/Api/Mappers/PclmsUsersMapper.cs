using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsUsersMapper : Profile {
        public PclmsUsersMapper() {
            CreateMap<PclmsUsers, PclmsUsersDisplayDto>();
            CreateMap<PclmsUsersCreateDto, PclmsUsers>();
            CreateMap<PclmsUsersUpdateDto, PclmsUsers>();
            CreateMap<PclmsUsersGetDto, PclmsUsers>();
        }
    }
}