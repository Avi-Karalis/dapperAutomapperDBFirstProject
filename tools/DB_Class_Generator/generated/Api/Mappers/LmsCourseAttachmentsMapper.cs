using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseAttachmentsMapper : Profile {
        public LmsCourseAttachmentsMapper() {
            CreateMap<LmsCourseAttachments, LmsCourseAttachmentsDisplayDto>();
            CreateMap<LmsCourseAttachmentsCreateDto, LmsCourseAttachments>();
            CreateMap<LmsCourseAttachmentsUpdateDto, LmsCourseAttachments>();
            CreateMap<LmsCourseAttachmentsGetDto, LmsCourseAttachments>();
        }
    }
}