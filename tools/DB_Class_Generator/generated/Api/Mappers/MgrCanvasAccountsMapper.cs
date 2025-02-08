using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasAccountsMapper : Profile {
        public MgrCanvasAccountsMapper() {
            CreateMap<MgrCanvasAccounts, MgrCanvasAccountsDisplayDto>();
            CreateMap<MgrCanvasAccountsCreateDto, MgrCanvasAccounts>();
            CreateMap<MgrCanvasAccountsUpdateDto, MgrCanvasAccounts>();
            CreateMap<MgrCanvasAccountsGetDto, MgrCanvasAccounts>();
        }
    }
}