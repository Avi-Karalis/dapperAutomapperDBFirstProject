using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseTaxonomiesMapper : Profile {
        public LmsCourseTaxonomiesMapper() {
            CreateMap<LmsCourseTaxonomies, LmsCourseTaxonomiesDisplayDto>();
            CreateMap<LmsCourseTaxonomiesCreateDto, LmsCourseTaxonomies>();
            CreateMap<LmsCourseTaxonomiesUpdateDto, LmsCourseTaxonomies>();
            CreateMap<LmsCourseTaxonomiesGetDto, LmsCourseTaxonomies>();
        }
    }
}