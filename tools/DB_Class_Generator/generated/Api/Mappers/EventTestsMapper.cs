using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class EventTestsMapper : Profile {
        public EventTestsMapper() {
            CreateMap<EventTests, EventTestsDisplayDto>();
            CreateMap<EventTestsCreateDto, EventTests>();
            CreateMap<EventTestsUpdateDto, EventTests>();
            CreateMap<EventTestsGetDto, EventTests>();
        }
    }
}