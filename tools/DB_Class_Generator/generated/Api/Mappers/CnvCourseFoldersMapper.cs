using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseFoldersMapper : Profile {
        public CnvCourseFoldersMapper() {
            CreateMap<CnvCourseFolders, CnvCourseFoldersDisplayDto>();
            CreateMap<CnvCourseFoldersCreateDto, CnvCourseFolders>();
            CreateMap<CnvCourseFoldersUpdateDto, CnvCourseFolders>();
            CreateMap<CnvCourseFoldersGetDto, CnvCourseFolders>();
        }
    }
}