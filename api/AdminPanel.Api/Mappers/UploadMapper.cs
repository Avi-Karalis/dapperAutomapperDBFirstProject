using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;
using AutoMapper;
namespace AdminPanel.Api.Mappers{
    public class UploadMapper : Profile {
        public UploadMapper(){
            CreateMap<Upload, Base64FileUploadDto>();
            CreateMap<Base64FileUploadDto, Upload>();
            CreateMap<IFormFile, Base64FileUploadDto>();
            CreateMap<Base64FileUploadDto,IFormFile>();
        }
    }
}