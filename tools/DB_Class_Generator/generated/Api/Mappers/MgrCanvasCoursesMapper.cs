using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasCoursesMapper : Profile {
        public MgrCanvasCoursesMapper() {
            CreateMap<MgrCanvasCourses, MgrCanvasCoursesDisplayDto>();
            CreateMap<MgrCanvasCoursesCreateDto, MgrCanvasCourses>();
            CreateMap<MgrCanvasCoursesUpdateDto, MgrCanvasCourses>();
            CreateMap<MgrCanvasCoursesGetDto, MgrCanvasCourses>();
        }
    }
}