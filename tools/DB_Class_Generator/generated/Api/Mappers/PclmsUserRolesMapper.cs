using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsUserRolesMapper : Profile {
        public PclmsUserRolesMapper() {
            CreateMap<PclmsUserRoles, PclmsUserRolesDisplayDto>();
            CreateMap<PclmsUserRolesCreateDto, PclmsUserRoles>();
            CreateMap<PclmsUserRolesUpdateDto, PclmsUserRoles>();
            CreateMap<PclmsUserRolesGetDto, PclmsUserRoles>();
        }
    }
}