using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsTranslationLanguagesMapper : Profile {
        public LmsTranslationLanguagesMapper() {
            CreateMap<LmsTranslationLanguages, LmsTranslationLanguagesDisplayDto>();
            CreateMap<LmsTranslationLanguagesCreateDto, LmsTranslationLanguages>();
            CreateMap<LmsTranslationLanguagesUpdateDto, LmsTranslationLanguages>();
            CreateMap<LmsTranslationLanguagesGetDto, LmsTranslationLanguages>();
        }
    }
}