using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsChatMapper : Profile {
        public LmsChatMapper() {
            CreateMap<LmsChat, LmsChatDisplayDto>();
            CreateMap<LmsChatCreateDto, LmsChat>();
            CreateMap<LmsChatUpdateDto, LmsChat>();
            CreateMap<LmsChatGetDto, LmsChat>();
        }
    }
}