using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCoursesMapper : Profile {
        public PclmsCoursesMapper() {
            CreateMap<PclmsCourses, PclmsCoursesDisplayDto>();
            CreateMap<PclmsCoursesCreateDto, PclmsCourses>();
            CreateMap<PclmsCoursesUpdateDto, PclmsCourses>();
            CreateMap<PclmsCoursesGetDto, PclmsCourses>();
        }
    }
}