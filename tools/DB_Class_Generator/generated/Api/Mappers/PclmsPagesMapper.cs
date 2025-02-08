using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsPagesMapper : Profile {
        public PclmsPagesMapper() {
            CreateMap<PclmsPages, PclmsPagesDisplayDto>();
            CreateMap<PclmsPagesCreateDto, PclmsPages>();
            CreateMap<PclmsPagesUpdateDto, PclmsPages>();
            CreateMap<PclmsPagesGetDto, PclmsPages>();
        }
    }
}