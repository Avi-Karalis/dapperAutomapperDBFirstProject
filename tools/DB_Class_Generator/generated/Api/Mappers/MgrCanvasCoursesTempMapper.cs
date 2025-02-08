using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasCoursesTempMapper : Profile {
        public MgrCanvasCoursesTempMapper() {
            CreateMap<MgrCanvasCoursesTemp, MgrCanvasCoursesTempDisplayDto>();
            CreateMap<MgrCanvasCoursesTempCreateDto, MgrCanvasCoursesTemp>();
            CreateMap<MgrCanvasCoursesTempUpdateDto, MgrCanvasCoursesTemp>();
            CreateMap<MgrCanvasCoursesTempGetDto, MgrCanvasCoursesTemp>();
        }
    }
}