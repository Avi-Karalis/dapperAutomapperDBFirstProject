using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsPositionsMapper : Profile {
        public LmsPositionsMapper() {
            CreateMap<LmsPositions, LmsPositionsDisplayDto>();
            CreateMap<LmsPositionsCreateDto, LmsPositions>();
            CreateMap<LmsPositionsUpdateDto, LmsPositions>();
            CreateMap<LmsPositionsGetDto, LmsPositions>();
        }
    }
}