using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsAccountModulesMapper : Profile {
        public PclmsAccountModulesMapper() {
            CreateMap<PclmsAccountModules, PclmsAccountModulesDisplayDto>();
            CreateMap<PclmsAccountModulesCreateDto, PclmsAccountModules>();
            CreateMap<PclmsAccountModulesUpdateDto, PclmsAccountModules>();
            CreateMap<PclmsAccountModulesGetDto, PclmsAccountModules>();
        }
    }
}