using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasDiscussionEntriesMapper : Profile {
        public MgrCanvasDiscussionEntriesMapper() {
            CreateMap<MgrCanvasDiscussionEntries, MgrCanvasDiscussionEntriesDisplayDto>();
            CreateMap<MgrCanvasDiscussionEntriesCreateDto, MgrCanvasDiscussionEntries>();
            CreateMap<MgrCanvasDiscussionEntriesUpdateDto, MgrCanvasDiscussionEntries>();
            CreateMap<MgrCanvasDiscussionEntriesGetDto, MgrCanvasDiscussionEntries>();
        }
    }
}