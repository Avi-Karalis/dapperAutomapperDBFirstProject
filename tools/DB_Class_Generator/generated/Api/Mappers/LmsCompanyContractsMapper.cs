using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCompanyContractsMapper : Profile {
        public LmsCompanyContractsMapper() {
            CreateMap<LmsCompanyContracts, LmsCompanyContractsDisplayDto>();
            CreateMap<LmsCompanyContractsCreateDto, LmsCompanyContracts>();
            CreateMap<LmsCompanyContractsUpdateDto, LmsCompanyContracts>();
            CreateMap<LmsCompanyContractsGetDto, LmsCompanyContracts>();
        }
    }
}