using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsSettingsMapper : Profile {
        public PclmsSettingsMapper() {
            CreateMap<PclmsSettings, PclmsSettingsDisplayDto>();
            CreateMap<PclmsSettingsCreateDto, PclmsSettings>();
            CreateMap<PclmsSettingsUpdateDto, PclmsSettings>();
            CreateMap<PclmsSettingsGetDto, PclmsSettings>();
        }
    }
}