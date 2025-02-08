using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsFilesMapper : Profile {
        public PclmsFilesMapper() {
            CreateMap<PclmsFiles, PclmsFilesDisplayDto>();
            CreateMap<PclmsFilesCreateDto, PclmsFiles>();
            CreateMap<PclmsFilesUpdateDto, PclmsFiles>();
            CreateMap<PclmsFilesGetDto, PclmsFiles>();
        }
    }
}