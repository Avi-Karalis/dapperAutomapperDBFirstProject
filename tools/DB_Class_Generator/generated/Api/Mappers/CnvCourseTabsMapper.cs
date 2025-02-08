using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseTabsMapper : Profile {
        public CnvCourseTabsMapper() {
            CreateMap<CnvCourseTabs, CnvCourseTabsDisplayDto>();
            CreateMap<CnvCourseTabsCreateDto, CnvCourseTabs>();
            CreateMap<CnvCourseTabsUpdateDto, CnvCourseTabs>();
            CreateMap<CnvCourseTabsGetDto, CnvCourseTabs>();
        }
    }
}