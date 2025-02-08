using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsIntegrationMapper : Profile {
        public LmsIntegrationMapper() {
            CreateMap<LmsIntegration, LmsIntegrationDisplayDto>();
            CreateMap<LmsIntegrationCreateDto, LmsIntegration>();
            CreateMap<LmsIntegrationUpdateDto, LmsIntegration>();
            CreateMap<LmsIntegrationGetDto, LmsIntegration>();
        }
    }
}