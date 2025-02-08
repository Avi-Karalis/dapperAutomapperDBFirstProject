using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsAssignmentsI18nService : CrudService<LmsAssignmentsI18n>, ILmsAssignmentsI18nService {
        public LmsAssignmentsI18nService(ILmsAssignmentsI18nRepository repository) : base(repository) {}
    }
}