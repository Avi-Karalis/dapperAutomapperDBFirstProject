using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MediaUploadsMapper : Profile {
        public MediaUploadsMapper() {
            CreateMap<MediaUploads, MediaUploadsDisplayDto>();
            CreateMap<MediaUploadsCreateDto, MediaUploads>();
            CreateMap<MediaUploadsUpdateDto, MediaUploads>();
            CreateMap<MediaUploadsGetDto, MediaUploads>();
        }
    }
}