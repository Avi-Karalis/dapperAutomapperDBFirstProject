using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseSectionsMapper : Profile {
        public PclmsCourseSectionsMapper() {
            CreateMap<PclmsCourseSections, PclmsCourseSectionsDisplayDto>();
            CreateMap<PclmsCourseSectionsCreateDto, PclmsCourseSections>();
            CreateMap<PclmsCourseSectionsUpdateDto, PclmsCourseSections>();
            CreateMap<PclmsCourseSectionsGetDto, PclmsCourseSections>();
        }
    }
}