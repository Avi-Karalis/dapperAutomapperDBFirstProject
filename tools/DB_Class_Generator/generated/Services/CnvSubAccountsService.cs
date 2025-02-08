using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvSubAccountsService : CrudService<CnvSubAccounts>, ICnvSubAccountsService {
        public CnvSubAccountsService(ICnvSubAccountsRepository repository) : base(repository) {}
    }
}