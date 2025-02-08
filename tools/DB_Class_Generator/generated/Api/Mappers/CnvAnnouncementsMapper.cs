using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvAnnouncementsMapper : Profile {
        public CnvAnnouncementsMapper() {
            CreateMap<CnvAnnouncements, CnvAnnouncementsDisplayDto>();
            CreateMap<CnvAnnouncementsCreateDto, CnvAnnouncements>();
            CreateMap<CnvAnnouncementsUpdateDto, CnvAnnouncements>();
            CreateMap<CnvAnnouncementsGetDto, CnvAnnouncements>();
        }
    }
}