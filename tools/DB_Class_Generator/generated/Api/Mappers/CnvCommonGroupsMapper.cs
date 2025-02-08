using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCommonGroupsMapper : Profile {
        public CnvCommonGroupsMapper() {
            CreateMap<CnvCommonGroups, CnvCommonGroupsDisplayDto>();
            CreateMap<CnvCommonGroupsCreateDto, CnvCommonGroups>();
            CreateMap<CnvCommonGroupsUpdateDto, CnvCommonGroups>();
            CreateMap<CnvCommonGroupsGetDto, CnvCommonGroups>();
        }
    }
}