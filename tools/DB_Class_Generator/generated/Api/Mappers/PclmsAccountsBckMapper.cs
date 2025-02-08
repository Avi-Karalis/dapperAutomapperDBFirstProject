using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsAccountsBckMapper : Profile {
        public PclmsAccountsBckMapper() {
            CreateMap<PclmsAccountsBck, PclmsAccountsBckDisplayDto>();
            CreateMap<PclmsAccountsBckCreateDto, PclmsAccountsBck>();
            CreateMap<PclmsAccountsBckUpdateDto, PclmsAccountsBck>();
            CreateMap<PclmsAccountsBckGetDto, PclmsAccountsBck>();
        }
    }
}