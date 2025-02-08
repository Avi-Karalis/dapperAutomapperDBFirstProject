using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class SessionsMapper : Profile {
        public SessionsMapper() {
            CreateMap<Sessions, SessionsDisplayDto>();
            CreateMap<SessionsCreateDto, Sessions>();
            CreateMap<SessionsUpdateDto, Sessions>();
            CreateMap<SessionsGetDto, Sessions>();
        }
    }
}