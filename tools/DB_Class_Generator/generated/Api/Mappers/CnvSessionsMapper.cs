using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvSessionsMapper : Profile {
        public CnvSessionsMapper() {
            CreateMap<CnvSessions, CnvSessionsDisplayDto>();
            CreateMap<CnvSessionsCreateDto, CnvSessions>();
            CreateMap<CnvSessionsUpdateDto, CnvSessions>();
            CreateMap<CnvSessionsGetDto, CnvSessions>();
        }
    }
}