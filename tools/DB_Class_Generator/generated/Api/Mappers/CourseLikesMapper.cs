using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CourseLikesMapper : Profile {
        public CourseLikesMapper() {
            CreateMap<CourseLikes, CourseLikesDisplayDto>();
            CreateMap<CourseLikesCreateDto, CourseLikes>();
            CreateMap<CourseLikesUpdateDto, CourseLikes>();
            CreateMap<CourseLikesGetDto, CourseLikes>();
        }
    }
}