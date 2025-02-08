using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseTransactionsMapper : Profile {
        public LmsCourseTransactionsMapper() {
            CreateMap<LmsCourseTransactions, LmsCourseTransactionsDisplayDto>();
            CreateMap<LmsCourseTransactionsCreateDto, LmsCourseTransactions>();
            CreateMap<LmsCourseTransactionsUpdateDto, LmsCourseTransactions>();
            CreateMap<LmsCourseTransactionsGetDto, LmsCourseTransactions>();
        }
    }
}