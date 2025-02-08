using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsTagsI18nMapper : Profile {
        public PclmsTagsI18nMapper() {
            CreateMap<PclmsTagsI18n, PclmsTagsI18nDisplayDto>();
            CreateMap<PclmsTagsI18nCreateDto, PclmsTagsI18n>();
            CreateMap<PclmsTagsI18nUpdateDto, PclmsTagsI18n>();
            CreateMap<PclmsTagsI18nGetDto, PclmsTagsI18n>();
        }
    }
}