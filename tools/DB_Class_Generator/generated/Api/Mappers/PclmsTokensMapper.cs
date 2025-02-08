using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsTokensMapper : Profile {
        public PclmsTokensMapper() {
            CreateMap<PclmsTokens, PclmsTokensDisplayDto>();
            CreateMap<PclmsTokensCreateDto, PclmsTokens>();
            CreateMap<PclmsTokensUpdateDto, PclmsTokens>();
            CreateMap<PclmsTokensGetDto, PclmsTokens>();
        }
    }
}