using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsIntegrationService : CrudService<LmsIntegration>, ILmsIntegrationService {
        public LmsIntegrationService(ILmsIntegrationRepository repository) : base(repository) {}
    }
}