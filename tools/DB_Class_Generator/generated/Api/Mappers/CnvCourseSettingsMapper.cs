using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseSettingsMapper : Profile {
        public CnvCourseSettingsMapper() {
            CreateMap<CnvCourseSettings, CnvCourseSettingsDisplayDto>();
            CreateMap<CnvCourseSettingsCreateDto, CnvCourseSettings>();
            CreateMap<CnvCourseSettingsUpdateDto, CnvCourseSettings>();
            CreateMap<CnvCourseSettingsGetDto, CnvCourseSettings>();
        }
    }
}