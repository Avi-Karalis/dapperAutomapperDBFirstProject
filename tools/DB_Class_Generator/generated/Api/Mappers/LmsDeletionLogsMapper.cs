using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsDeletionLogsMapper : Profile {
        public LmsDeletionLogsMapper() {
            CreateMap<LmsDeletionLogs, LmsDeletionLogsDisplayDto>();
            CreateMap<LmsDeletionLogsCreateDto, LmsDeletionLogs>();
            CreateMap<LmsDeletionLogsUpdateDto, LmsDeletionLogs>();
            CreateMap<LmsDeletionLogsGetDto, LmsDeletionLogs>();
        }
    }
}