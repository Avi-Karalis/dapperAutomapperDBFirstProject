using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PermissionsMapper : Profile {
        public PermissionsMapper() {
            CreateMap<Permissions, PermissionsDisplayDto>();
            CreateMap<PermissionsCreateDto, Permissions>();
            CreateMap<PermissionsUpdateDto, Permissions>();
            CreateMap<PermissionsGetDto, Permissions>();
        }
    }
}