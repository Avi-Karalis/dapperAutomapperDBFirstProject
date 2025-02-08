using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CoursesMapper : Profile {
        public CoursesMapper() {
            CreateMap<Courses, CoursesDisplayDto>();
            CreateMap<CoursesCreateDto, Courses>();
            CreateMap<CoursesUpdateDto, Courses>();
            CreateMap<CoursesGetDto, Courses>();
        }
    }
}