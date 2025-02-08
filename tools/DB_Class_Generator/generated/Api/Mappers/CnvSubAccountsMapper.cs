using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvSubAccountsMapper : Profile {
        public CnvSubAccountsMapper() {
            CreateMap<CnvSubAccounts, CnvSubAccountsDisplayDto>();
            CreateMap<CnvSubAccountsCreateDto, CnvSubAccounts>();
            CreateMap<CnvSubAccountsUpdateDto, CnvSubAccounts>();
            CreateMap<CnvSubAccountsGetDto, CnvSubAccounts>();
        }
    }
}