using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsAssignmentsMapper : Profile {
        public LmsAssignmentsMapper() {
            CreateMap<LmsAssignments, LmsAssignmentsDisplayDto>();
            CreateMap<LmsAssignmentsCreateDto, LmsAssignments>();
            CreateMap<LmsAssignmentsUpdateDto, LmsAssignments>();
            CreateMap<LmsAssignmentsGetDto, LmsAssignments>();
        }
    }
}