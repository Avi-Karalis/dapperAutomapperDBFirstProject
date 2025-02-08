using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseSessionsTranslationsMapper : Profile {
        public LmsCourseSessionsTranslationsMapper() {
            CreateMap<LmsCourseSessionsTranslations, LmsCourseSessionsTranslationsDisplayDto>();
            CreateMap<LmsCourseSessionsTranslationsCreateDto, LmsCourseSessionsTranslations>();
            CreateMap<LmsCourseSessionsTranslationsUpdateDto, LmsCourseSessionsTranslations>();
            CreateMap<LmsCourseSessionsTranslationsGetDto, LmsCourseSessionsTranslations>();
        }
    }
}