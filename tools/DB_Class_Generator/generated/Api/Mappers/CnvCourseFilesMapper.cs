using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseFilesMapper : Profile {
        public CnvCourseFilesMapper() {
            CreateMap<CnvCourseFiles, CnvCourseFilesDisplayDto>();
            CreateMap<CnvCourseFilesCreateDto, CnvCourseFiles>();
            CreateMap<CnvCourseFilesUpdateDto, CnvCourseFiles>();
            CreateMap<CnvCourseFilesGetDto, CnvCourseFiles>();
        }
    }
}