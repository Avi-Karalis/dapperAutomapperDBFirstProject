using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsRolesMapper : Profile {
        public PclmsRolesMapper() {
            CreateMap<PclmsRoles, PclmsRolesDisplayDto>();
            CreateMap<PclmsRolesCreateDto, PclmsRoles>();
            CreateMap<PclmsRolesUpdateDto, PclmsRoles>();
            CreateMap<PclmsRolesGetDto, PclmsRoles>();
        }
    }
}