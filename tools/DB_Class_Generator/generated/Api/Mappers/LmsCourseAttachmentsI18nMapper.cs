using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseAttachmentsI18nMapper : Profile {
        public LmsCourseAttachmentsI18nMapper() {
            CreateMap<LmsCourseAttachmentsI18n, LmsCourseAttachmentsI18nDisplayDto>();
            CreateMap<LmsCourseAttachmentsI18nCreateDto, LmsCourseAttachmentsI18n>();
            CreateMap<LmsCourseAttachmentsI18nUpdateDto, LmsCourseAttachmentsI18n>();
            CreateMap<LmsCourseAttachmentsI18nGetDto, LmsCourseAttachmentsI18n>();
        }
    }
}