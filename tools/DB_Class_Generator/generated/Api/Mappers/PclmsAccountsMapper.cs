using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsAccountsMapper : Profile {
        public PclmsAccountsMapper() {
            CreateMap<PclmsAccounts, PclmsAccountsDisplayDto>();
            CreateMap<PclmsAccountsCreateDto, PclmsAccounts>();
            CreateMap<PclmsAccountsUpdateDto, PclmsAccounts>();
            CreateMap<PclmsAccountsGetDto, PclmsAccounts>();
        }
    }
}