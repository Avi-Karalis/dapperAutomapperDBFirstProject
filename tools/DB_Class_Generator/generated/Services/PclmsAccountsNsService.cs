using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsAccountsNsService : CrudService<PclmsAccountsNs>, IPclmsAccountsNsService {
        public PclmsAccountsNsService(IPclmsAccountsNsRepository repository) : base(repository) {}
    }
}