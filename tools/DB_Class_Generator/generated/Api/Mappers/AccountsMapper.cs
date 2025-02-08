using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class AccountsMapper : Profile {
        public AccountsMapper() {
            CreateMap<Accounts, AccountsDisplayDto>();
            CreateMap<AccountsCreateDto, Accounts>();
            CreateMap<AccountsUpdateDto, Accounts>();
            CreateMap<AccountsGetDto, Accounts>();
        }
    }
}