using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class SectionContentsMapper : Profile {
        public SectionContentsMapper() {
            CreateMap<SectionContents, SectionContentsDisplayDto>();
            CreateMap<SectionContentsCreateDto, SectionContents>();
            CreateMap<SectionContentsUpdateDto, SectionContents>();
            CreateMap<SectionContentsGetDto, SectionContents>();
        }
    }
}