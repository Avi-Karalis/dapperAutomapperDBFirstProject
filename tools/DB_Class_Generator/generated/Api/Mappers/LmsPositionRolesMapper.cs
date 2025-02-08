using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsPositionRolesMapper : Profile {
        public LmsPositionRolesMapper() {
            CreateMap<LmsPositionRoles, LmsPositionRolesDisplayDto>();
            CreateMap<LmsPositionRolesCreateDto, LmsPositionRoles>();
            CreateMap<LmsPositionRolesUpdateDto, LmsPositionRoles>();
            CreateMap<LmsPositionRolesGetDto, LmsPositionRoles>();
        }
    }
}