using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseRecentStudentsMapper : Profile {
        public CnvCourseRecentStudentsMapper() {
            CreateMap<CnvCourseRecentStudents, CnvCourseRecentStudentsDisplayDto>();
            CreateMap<CnvCourseRecentStudentsCreateDto, CnvCourseRecentStudents>();
            CreateMap<CnvCourseRecentStudentsUpdateDto, CnvCourseRecentStudents>();
            CreateMap<CnvCourseRecentStudentsGetDto, CnvCourseRecentStudents>();
        }
    }
}