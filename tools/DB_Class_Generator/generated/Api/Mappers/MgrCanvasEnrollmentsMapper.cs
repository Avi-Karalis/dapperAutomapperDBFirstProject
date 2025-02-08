using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasEnrollmentsMapper : Profile {
        public MgrCanvasEnrollmentsMapper() {
            CreateMap<MgrCanvasEnrollments, MgrCanvasEnrollmentsDisplayDto>();
            CreateMap<MgrCanvasEnrollmentsCreateDto, MgrCanvasEnrollments>();
            CreateMap<MgrCanvasEnrollmentsUpdateDto, MgrCanvasEnrollments>();
            CreateMap<MgrCanvasEnrollmentsGetDto, MgrCanvasEnrollments>();
        }
    }
}