using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsFoldersMapper : Profile {
        public PclmsFoldersMapper() {
            CreateMap<PclmsFolders, PclmsFoldersDisplayDto>();
            CreateMap<PclmsFoldersCreateDto, PclmsFolders>();
            CreateMap<PclmsFoldersUpdateDto, PclmsFolders>();
            CreateMap<PclmsFoldersGetDto, PclmsFolders>();
        }
    }
}