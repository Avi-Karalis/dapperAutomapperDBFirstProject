using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LanguagesExtMapper : Profile {
        public LanguagesExtMapper() {
            CreateMap<LanguagesExt, LanguagesExtDisplayDto>();
            CreateMap<LanguagesExtCreateDto, LanguagesExt>();
            CreateMap<LanguagesExtUpdateDto, LanguagesExt>();
            CreateMap<LanguagesExtGetDto, LanguagesExt>();
        }
    }
}