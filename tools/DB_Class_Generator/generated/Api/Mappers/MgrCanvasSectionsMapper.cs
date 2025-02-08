using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasSectionsMapper : Profile {
        public MgrCanvasSectionsMapper() {
            CreateMap<MgrCanvasSections, MgrCanvasSectionsDisplayDto>();
            CreateMap<MgrCanvasSectionsCreateDto, MgrCanvasSections>();
            CreateMap<MgrCanvasSectionsUpdateDto, MgrCanvasSections>();
            CreateMap<MgrCanvasSectionsGetDto, MgrCanvasSections>();
        }
    }
}