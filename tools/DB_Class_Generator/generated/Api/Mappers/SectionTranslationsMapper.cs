using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class SectionTranslationsMapper : Profile {
        public SectionTranslationsMapper() {
            CreateMap<SectionTranslations, SectionTranslationsDisplayDto>();
            CreateMap<SectionTranslationsCreateDto, SectionTranslations>();
            CreateMap<SectionTranslationsUpdateDto, SectionTranslations>();
            CreateMap<SectionTranslationsGetDto, SectionTranslations>();
        }
    }
}