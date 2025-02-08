using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvAccountUsersMapper : Profile {
        public CnvAccountUsersMapper() {
            CreateMap<CnvAccountUsers, CnvAccountUsersDisplayDto>();
            CreateMap<CnvAccountUsersCreateDto, CnvAccountUsers>();
            CreateMap<CnvAccountUsersUpdateDto, CnvAccountUsers>();
            CreateMap<CnvAccountUsersGetDto, CnvAccountUsers>();
        }
    }
}