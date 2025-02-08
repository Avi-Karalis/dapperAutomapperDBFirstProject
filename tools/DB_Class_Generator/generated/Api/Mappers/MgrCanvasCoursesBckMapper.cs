using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasCoursesBckMapper : Profile {
        public MgrCanvasCoursesBckMapper() {
            CreateMap<MgrCanvasCoursesBck, MgrCanvasCoursesBckDisplayDto>();
            CreateMap<MgrCanvasCoursesBckCreateDto, MgrCanvasCoursesBck>();
            CreateMap<MgrCanvasCoursesBckUpdateDto, MgrCanvasCoursesBck>();
            CreateMap<MgrCanvasCoursesBckGetDto, MgrCanvasCoursesBck>();
        }
    }
}