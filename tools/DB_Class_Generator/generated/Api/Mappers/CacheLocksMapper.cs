using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CacheLocksMapper : Profile {
        public CacheLocksMapper() {
            CreateMap<CacheLocks, CacheLocksDisplayDto>();
            CreateMap<CacheLocksCreateDto, CacheLocks>();
            CreateMap<CacheLocksUpdateDto, CacheLocks>();
            CreateMap<CacheLocksGetDto, CacheLocks>();
        }
    }
}