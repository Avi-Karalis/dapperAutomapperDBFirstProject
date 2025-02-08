using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasDiscussionTopicsMapper : Profile {
        public MgrCanvasDiscussionTopicsMapper() {
            CreateMap<MgrCanvasDiscussionTopics, MgrCanvasDiscussionTopicsDisplayDto>();
            CreateMap<MgrCanvasDiscussionTopicsCreateDto, MgrCanvasDiscussionTopics>();
            CreateMap<MgrCanvasDiscussionTopicsUpdateDto, MgrCanvasDiscussionTopics>();
            CreateMap<MgrCanvasDiscussionTopicsGetDto, MgrCanvasDiscussionTopics>();
        }
    }
}