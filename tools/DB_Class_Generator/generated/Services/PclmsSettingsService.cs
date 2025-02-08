using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsSettingsService : CrudService<PclmsSettings>, IPclmsSettingsService {
        public PclmsSettingsService(IPclmsSettingsRepository repository) : base(repository) {}
    }
}