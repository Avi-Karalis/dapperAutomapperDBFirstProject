using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsWatchdogMapper : Profile {
        public PclmsWatchdogMapper() {
            CreateMap<PclmsWatchdog, PclmsWatchdogDisplayDto>();
            CreateMap<PclmsWatchdogCreateDto, PclmsWatchdog>();
            CreateMap<PclmsWatchdogUpdateDto, PclmsWatchdog>();
            CreateMap<PclmsWatchdogGetDto, PclmsWatchdog>();
        }
    }
}