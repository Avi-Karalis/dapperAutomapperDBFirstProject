using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class NestedSetTestMapper : Profile {
        public NestedSetTestMapper() {
            CreateMap<NestedSetTest, NestedSetTestDisplayDto>();
            CreateMap<NestedSetTestCreateDto, NestedSetTest>();
            CreateMap<NestedSetTestUpdateDto, NestedSetTest>();
            CreateMap<NestedSetTestGetDto, NestedSetTest>();
        }
    }
}