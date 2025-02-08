using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseEnrollmentsMapper : Profile {
        public CnvCourseEnrollmentsMapper() {
            CreateMap<CnvCourseEnrollments, CnvCourseEnrollmentsDisplayDto>();
            CreateMap<CnvCourseEnrollmentsCreateDto, CnvCourseEnrollments>();
            CreateMap<CnvCourseEnrollmentsUpdateDto, CnvCourseEnrollments>();
            CreateMap<CnvCourseEnrollmentsGetDto, CnvCourseEnrollments>();
        }
    }
}