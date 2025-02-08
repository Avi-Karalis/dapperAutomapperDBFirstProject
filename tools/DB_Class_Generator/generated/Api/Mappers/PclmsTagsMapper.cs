using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsTagsMapper : Profile {
        public PclmsTagsMapper() {
            CreateMap<PclmsTags, PclmsTagsDisplayDto>();
            CreateMap<PclmsTagsCreateDto, PclmsTags>();
            CreateMap<PclmsTagsUpdateDto, PclmsTags>();
            CreateMap<PclmsTagsGetDto, PclmsTags>();
        }
    }
}