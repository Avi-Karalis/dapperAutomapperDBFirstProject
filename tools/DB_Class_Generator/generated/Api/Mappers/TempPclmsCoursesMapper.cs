using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class TempPclmsCoursesMapper : Profile {
        public TempPclmsCoursesMapper() {
            CreateMap<TempPclmsCourses, TempPclmsCoursesDisplayDto>();
            CreateMap<TempPclmsCoursesCreateDto, TempPclmsCourses>();
            CreateMap<TempPclmsCoursesUpdateDto, TempPclmsCourses>();
            CreateMap<TempPclmsCoursesGetDto, TempPclmsCourses>();
        }
    }
}