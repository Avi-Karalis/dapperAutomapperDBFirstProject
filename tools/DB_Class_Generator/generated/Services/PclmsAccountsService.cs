using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsAccountsService : CrudService<PclmsAccounts>, IPclmsAccountsService {
        public PclmsAccountsService(IPclmsAccountsRepository repository) : base(repository) {}
    }
}