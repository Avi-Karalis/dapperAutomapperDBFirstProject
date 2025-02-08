using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseSectionsMapper : Profile {
        public CnvCourseSectionsMapper() {
            CreateMap<CnvCourseSections, CnvCourseSectionsDisplayDto>();
            CreateMap<CnvCourseSectionsCreateDto, CnvCourseSections>();
            CreateMap<CnvCourseSectionsUpdateDto, CnvCourseSections>();
            CreateMap<CnvCourseSectionsGetDto, CnvCourseSections>();
        }
    }
}