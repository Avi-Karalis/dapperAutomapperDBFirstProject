using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsLovsMapper : Profile {
        public LmsLovsMapper() {
            CreateMap<LmsLovs, LmsLovsDisplayDto>();
            CreateMap<LmsLovsCreateDto, LmsLovs>();
            CreateMap<LmsLovsUpdateDto, LmsLovs>();
            CreateMap<LmsLovsGetDto, LmsLovs>();
        }
    }
}