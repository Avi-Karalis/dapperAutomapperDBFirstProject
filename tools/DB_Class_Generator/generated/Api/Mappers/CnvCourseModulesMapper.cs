using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseModulesMapper : Profile {
        public CnvCourseModulesMapper() {
            CreateMap<CnvCourseModules, CnvCourseModulesDisplayDto>();
            CreateMap<CnvCourseModulesCreateDto, CnvCourseModules>();
            CreateMap<CnvCourseModulesUpdateDto, CnvCourseModules>();
            CreateMap<CnvCourseModulesGetDto, CnvCourseModules>();
        }
    }
}