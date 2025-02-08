using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class QueueJobsMapper : Profile {
        public QueueJobsMapper() {
            CreateMap<QueueJobs, QueueJobsDisplayDto>();
            CreateMap<QueueJobsCreateDto, QueueJobs>();
            CreateMap<QueueJobsUpdateDto, QueueJobs>();
            CreateMap<QueueJobsGetDto, QueueJobs>();
        }
    }
}