using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseModulesMapper : Profile {
        public PclmsCourseModulesMapper() {
            CreateMap<PclmsCourseModules, PclmsCourseModulesDisplayDto>();
            CreateMap<PclmsCourseModulesCreateDto, PclmsCourseModules>();
            CreateMap<PclmsCourseModulesUpdateDto, PclmsCourseModules>();
            CreateMap<PclmsCourseModulesGetDto, PclmsCourseModules>();
        }
    }
}