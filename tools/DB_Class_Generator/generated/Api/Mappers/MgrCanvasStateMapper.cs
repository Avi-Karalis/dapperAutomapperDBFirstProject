using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasStateMapper : Profile {
        public MgrCanvasStateMapper() {
            CreateMap<MgrCanvasState, MgrCanvasStateDisplayDto>();
            CreateMap<MgrCanvasStateCreateDto, MgrCanvasState>();
            CreateMap<MgrCanvasStateUpdateDto, MgrCanvasState>();
            CreateMap<MgrCanvasStateGetDto, MgrCanvasState>();
        }
    }
}