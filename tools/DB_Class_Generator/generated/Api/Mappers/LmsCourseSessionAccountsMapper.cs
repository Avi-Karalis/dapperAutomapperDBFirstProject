using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseSessionAccountsMapper : Profile {
        public LmsCourseSessionAccountsMapper() {
            CreateMap<LmsCourseSessionAccounts, LmsCourseSessionAccountsDisplayDto>();
            CreateMap<LmsCourseSessionAccountsCreateDto, LmsCourseSessionAccounts>();
            CreateMap<LmsCourseSessionAccountsUpdateDto, LmsCourseSessionAccounts>();
            CreateMap<LmsCourseSessionAccountsGetDto, LmsCourseSessionAccounts>();
        }
    }
}