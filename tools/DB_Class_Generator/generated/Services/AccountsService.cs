using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class AccountsService : CrudService<Accounts>, IAccountsService {
        public AccountsService(IAccountsRepository repository) : base(repository) {}
    }
}