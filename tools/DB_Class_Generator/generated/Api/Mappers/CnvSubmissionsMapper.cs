using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvSubmissionsMapper : Profile {
        public CnvSubmissionsMapper() {
            CreateMap<CnvSubmissions, CnvSubmissionsDisplayDto>();
            CreateMap<CnvSubmissionsCreateDto, CnvSubmissions>();
            CreateMap<CnvSubmissionsUpdateDto, CnvSubmissions>();
            CreateMap<CnvSubmissionsGetDto, CnvSubmissions>();
        }
    }
}