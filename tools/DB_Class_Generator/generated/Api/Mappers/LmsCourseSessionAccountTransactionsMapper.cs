using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseSessionAccountTransactionsMapper : Profile {
        public LmsCourseSessionAccountTransactionsMapper() {
            CreateMap<LmsCourseSessionAccountTransactions, LmsCourseSessionAccountTransactionsDisplayDto>();
            CreateMap<LmsCourseSessionAccountTransactionsCreateDto, LmsCourseSessionAccountTransactions>();
            CreateMap<LmsCourseSessionAccountTransactionsUpdateDto, LmsCourseSessionAccountTransactions>();
            CreateMap<LmsCourseSessionAccountTransactionsGetDto, LmsCourseSessionAccountTransactions>();
        }
    }
}