using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class SectionContentTranslationsMapper : Profile {
        public SectionContentTranslationsMapper() {
            CreateMap<SectionContentTranslations, SectionContentTranslationsDisplayDto>();
            CreateMap<SectionContentTranslationsCreateDto, SectionContentTranslations>();
            CreateMap<SectionContentTranslationsUpdateDto, SectionContentTranslations>();
            CreateMap<SectionContentTranslationsGetDto, SectionContentTranslations>();
        }
    }
}