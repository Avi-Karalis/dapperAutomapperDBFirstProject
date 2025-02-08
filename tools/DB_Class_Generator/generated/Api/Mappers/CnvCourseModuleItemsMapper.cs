using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseModuleItemsMapper : Profile {
        public CnvCourseModuleItemsMapper() {
            CreateMap<CnvCourseModuleItems, CnvCourseModuleItemsDisplayDto>();
            CreateMap<CnvCourseModuleItemsCreateDto, CnvCourseModuleItems>();
            CreateMap<CnvCourseModuleItemsUpdateDto, CnvCourseModuleItems>();
            CreateMap<CnvCourseModuleItemsGetDto, CnvCourseModuleItems>();
        }
    }
}