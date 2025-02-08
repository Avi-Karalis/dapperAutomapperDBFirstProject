using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CacheMapper : Profile {
        public CacheMapper() {
            CreateMap<Cache, CacheDisplayDto>();
            CreateMap<CacheCreateDto, Cache>();
            CreateMap<CacheUpdateDto, Cache>();
            CreateMap<CacheGetDto, Cache>();
        }
    }
}