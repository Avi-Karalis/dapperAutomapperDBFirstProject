using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseAssetsMapper : Profile {
        public LmsCourseAssetsMapper() {
            CreateMap<LmsCourseAssets, LmsCourseAssetsDisplayDto>();
            CreateMap<LmsCourseAssetsCreateDto, LmsCourseAssets>();
            CreateMap<LmsCourseAssetsUpdateDto, LmsCourseAssets>();
            CreateMap<LmsCourseAssetsGetDto, LmsCourseAssets>();
        }
    }
}