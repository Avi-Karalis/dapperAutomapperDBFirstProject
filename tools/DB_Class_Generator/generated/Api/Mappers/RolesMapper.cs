using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class RolesMapper : Profile {
        public RolesMapper() {
            CreateMap<Roles, RolesDisplayDto>();
            CreateMap<RolesCreateDto, Roles>();
            CreateMap<RolesUpdateDto, Roles>();
            CreateMap<RolesGetDto, Roles>();
        }
    }
}