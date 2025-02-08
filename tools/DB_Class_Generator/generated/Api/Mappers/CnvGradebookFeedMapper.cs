using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvGradebookFeedMapper : Profile {
        public CnvGradebookFeedMapper() {
            CreateMap<CnvGradebookFeed, CnvGradebookFeedDisplayDto>();
            CreateMap<CnvGradebookFeedCreateDto, CnvGradebookFeed>();
            CreateMap<CnvGradebookFeedUpdateDto, CnvGradebookFeed>();
            CreateMap<CnvGradebookFeedGetDto, CnvGradebookFeed>();
        }
    }
}