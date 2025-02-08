using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsRolePermissionsMapper : Profile {
        public PclmsRolePermissionsMapper() {
            CreateMap<PclmsRolePermissions, PclmsRolePermissionsDisplayDto>();
            CreateMap<PclmsRolePermissionsCreateDto, PclmsRolePermissions>();
            CreateMap<PclmsRolePermissionsUpdateDto, PclmsRolePermissions>();
            CreateMap<PclmsRolePermissionsGetDto, PclmsRolePermissions>();
        }
    }
}