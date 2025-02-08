using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsTaxonomyTranslationsMapper : Profile {
        public LmsTaxonomyTranslationsMapper() {
            CreateMap<LmsTaxonomyTranslations, LmsTaxonomyTranslationsDisplayDto>();
            CreateMap<LmsTaxonomyTranslationsCreateDto, LmsTaxonomyTranslations>();
            CreateMap<LmsTaxonomyTranslationsUpdateDto, LmsTaxonomyTranslations>();
            CreateMap<LmsTaxonomyTranslationsGetDto, LmsTaxonomyTranslations>();
        }
    }
}