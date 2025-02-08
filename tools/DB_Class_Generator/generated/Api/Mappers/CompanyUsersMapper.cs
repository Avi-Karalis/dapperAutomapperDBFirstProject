using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CompanyUsersMapper : Profile {
        public CompanyUsersMapper() {
            CreateMap<CompanyUsers, CompanyUsersDisplayDto>();
            CreateMap<CompanyUsersCreateDto, CompanyUsers>();
            CreateMap<CompanyUsersUpdateDto, CompanyUsers>();
            CreateMap<CompanyUsersGetDto, CompanyUsers>();
        }
    }
}