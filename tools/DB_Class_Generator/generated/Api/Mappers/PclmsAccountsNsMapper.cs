using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsAccountsNsMapper : Profile {
        public PclmsAccountsNsMapper() {
            CreateMap<PclmsAccountsNs, PclmsAccountsNsDisplayDto>();
            CreateMap<PclmsAccountsNsCreateDto, PclmsAccountsNs>();
            CreateMap<PclmsAccountsNsUpdateDto, PclmsAccountsNs>();
            CreateMap<PclmsAccountsNsGetDto, PclmsAccountsNs>();
        }
    }
}