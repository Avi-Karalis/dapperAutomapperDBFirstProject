using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class DotnetUploadMapper : Profile {
        public DotnetUploadMapper() {
            CreateMap<DotnetUpload, DotnetUploadDisplayDto>();
            CreateMap<DotnetUploadCreateDto, DotnetUpload>();
            CreateMap<DotnetUploadUpdateDto, DotnetUpload>();
            CreateMap<DotnetUploadGetDto, DotnetUpload>();
        }
    }
}