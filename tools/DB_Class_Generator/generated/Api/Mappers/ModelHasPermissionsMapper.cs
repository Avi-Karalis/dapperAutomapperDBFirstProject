using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class ModelHasPermissionsMapper : Profile {
        public ModelHasPermissionsMapper() {
            CreateMap<ModelHasPermissions, ModelHasPermissionsDisplayDto>();
            CreateMap<ModelHasPermissionsCreateDto, ModelHasPermissions>();
            CreateMap<ModelHasPermissionsUpdateDto, ModelHasPermissions>();
            CreateMap<ModelHasPermissionsGetDto, ModelHasPermissions>();
        }
    }
}