using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LanguagesMapper : Profile {
        public LanguagesMapper() {
            CreateMap<Languages, LanguagesDisplayDto>();
            CreateMap<LanguagesCreateDto, Languages>();
            CreateMap<LanguagesUpdateDto, Languages>();
            CreateMap<LanguagesGetDto, Languages>();
        }
    }
}