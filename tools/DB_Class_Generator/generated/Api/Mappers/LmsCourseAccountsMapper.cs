using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseAccountsMapper : Profile {
        public LmsCourseAccountsMapper() {
            CreateMap<LmsCourseAccounts, LmsCourseAccountsDisplayDto>();
            CreateMap<LmsCourseAccountsCreateDto, LmsCourseAccounts>();
            CreateMap<LmsCourseAccountsUpdateDto, LmsCourseAccounts>();
            CreateMap<LmsCourseAccountsGetDto, LmsCourseAccounts>();
        }
    }
}