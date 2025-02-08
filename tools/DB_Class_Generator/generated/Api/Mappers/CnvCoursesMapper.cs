using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCoursesMapper : Profile {
        public CnvCoursesMapper() {
            CreateMap<CnvCourses, CnvCoursesDisplayDto>();
            CreateMap<CnvCoursesCreateDto, CnvCourses>();
            CreateMap<CnvCoursesUpdateDto, CnvCourses>();
            CreateMap<CnvCoursesGetDto, CnvCourses>();
        }
    }
}