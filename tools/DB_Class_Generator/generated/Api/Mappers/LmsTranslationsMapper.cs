using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsTranslationsMapper : Profile {
        public LmsTranslationsMapper() {
            CreateMap<LmsTranslations, LmsTranslationsDisplayDto>();
            CreateMap<LmsTranslationsCreateDto, LmsTranslations>();
            CreateMap<LmsTranslationsUpdateDto, LmsTranslations>();
            CreateMap<LmsTranslationsGetDto, LmsTranslations>();
        }
    }
}