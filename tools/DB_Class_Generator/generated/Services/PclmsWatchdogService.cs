using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsWatchdogService : CrudService<PclmsWatchdog>, IPclmsWatchdogService {
        public PclmsWatchdogService(IPclmsWatchdogRepository repository) : base(repository) {}
    }
}