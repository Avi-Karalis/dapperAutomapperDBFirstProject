using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LanguagesI18nMapper : Profile {
        public LanguagesI18nMapper() {
            CreateMap<LanguagesI18n, LanguagesI18nDisplayDto>();
            CreateMap<LanguagesI18nCreateDto, LanguagesI18n>();
            CreateMap<LanguagesI18nUpdateDto, LanguagesI18n>();
            CreateMap<LanguagesI18nGetDto, LanguagesI18n>();
        }
    }
}