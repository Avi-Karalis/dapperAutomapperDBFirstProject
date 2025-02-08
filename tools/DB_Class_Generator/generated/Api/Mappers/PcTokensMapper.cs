using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PcTokensMapper : Profile {
        public PcTokensMapper() {
            CreateMap<PcTokens, PcTokensDisplayDto>();
            CreateMap<PcTokensCreateDto, PcTokens>();
            CreateMap<PcTokensUpdateDto, PcTokens>();
            CreateMap<PcTokensGetDto, PcTokens>();
        }
    }
}