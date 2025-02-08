using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class ModelHasRolesMapper : Profile {
        public ModelHasRolesMapper() {
            CreateMap<ModelHasRoles, ModelHasRolesDisplayDto>();
            CreateMap<ModelHasRolesCreateDto, ModelHasRoles>();
            CreateMap<ModelHasRolesUpdateDto, ModelHasRoles>();
            CreateMap<ModelHasRolesGetDto, ModelHasRoles>();
        }
    }
}