using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseAssignmentsMapper : Profile {
        public CnvCourseAssignmentsMapper() {
            CreateMap<CnvCourseAssignments, CnvCourseAssignmentsDisplayDto>();
            CreateMap<CnvCourseAssignmentsCreateDto, CnvCourseAssignments>();
            CreateMap<CnvCourseAssignmentsUpdateDto, CnvCourseAssignments>();
            CreateMap<CnvCourseAssignmentsGetDto, CnvCourseAssignments>();
        }
    }
}