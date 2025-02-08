using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsAssignmentsService : CrudService<LmsAssignments>, ILmsAssignmentsService {
        public LmsAssignmentsService(ILmsAssignmentsRepository repository) : base(repository) {}
    }
}