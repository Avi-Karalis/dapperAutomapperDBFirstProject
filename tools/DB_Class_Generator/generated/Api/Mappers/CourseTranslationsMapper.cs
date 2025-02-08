using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CourseTranslationsMapper : Profile {
        public CourseTranslationsMapper() {
            CreateMap<CourseTranslations, CourseTranslationsDisplayDto>();
            CreateMap<CourseTranslationsCreateDto, CourseTranslations>();
            CreateMap<CourseTranslationsUpdateDto, CourseTranslations>();
            CreateMap<CourseTranslationsGetDto, CourseTranslations>();
        }
    }
}