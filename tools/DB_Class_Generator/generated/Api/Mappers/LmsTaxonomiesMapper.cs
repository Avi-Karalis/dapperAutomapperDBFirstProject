using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsTaxonomiesMapper : Profile {
        public LmsTaxonomiesMapper() {
            CreateMap<LmsTaxonomies, LmsTaxonomiesDisplayDto>();
            CreateMap<LmsTaxonomiesCreateDto, LmsTaxonomies>();
            CreateMap<LmsTaxonomiesUpdateDto, LmsTaxonomies>();
            CreateMap<LmsTaxonomiesGetDto, LmsTaxonomies>();
        }
    }
}