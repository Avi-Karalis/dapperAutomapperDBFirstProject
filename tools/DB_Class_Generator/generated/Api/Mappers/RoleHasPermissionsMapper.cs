using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class RoleHasPermissionsMapper : Profile {
        public RoleHasPermissionsMapper() {
            CreateMap<RoleHasPermissions, RoleHasPermissionsDisplayDto>();
            CreateMap<RoleHasPermissionsCreateDto, RoleHasPermissions>();
            CreateMap<RoleHasPermissionsUpdateDto, RoleHasPermissions>();
            CreateMap<RoleHasPermissionsGetDto, RoleHasPermissions>();
        }
    }
}