using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasCourseMapper : Profile {
        public MgrCanvasCourseMapper() {
            CreateMap<MgrCanvasCourse, MgrCanvasCourseDisplayDto>();
            CreateMap<MgrCanvasCourseCreateDto, MgrCanvasCourse>();
            CreateMap<MgrCanvasCourseUpdateDto, MgrCanvasCourse>();
            CreateMap<MgrCanvasCourseGetDto, MgrCanvasCourse>();
        }
    }
}