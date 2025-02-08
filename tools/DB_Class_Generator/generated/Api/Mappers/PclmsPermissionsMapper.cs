using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsPermissionsMapper : Profile {
        public PclmsPermissionsMapper() {
            CreateMap<PclmsPermissions, PclmsPermissionsDisplayDto>();
            CreateMap<PclmsPermissionsCreateDto, PclmsPermissions>();
            CreateMap<PclmsPermissionsUpdateDto, PclmsPermissions>();
            CreateMap<PclmsPermissionsGetDto, PclmsPermissions>();
        }
    }
}