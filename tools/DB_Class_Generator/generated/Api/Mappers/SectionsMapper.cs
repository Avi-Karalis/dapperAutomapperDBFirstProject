using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class SectionsMapper : Profile {
        public SectionsMapper() {
            CreateMap<Sections, SectionsDisplayDto>();
            CreateMap<SectionsCreateDto, Sections>();
            CreateMap<SectionsUpdateDto, Sections>();
            CreateMap<SectionsGetDto, Sections>();
        }
    }
}