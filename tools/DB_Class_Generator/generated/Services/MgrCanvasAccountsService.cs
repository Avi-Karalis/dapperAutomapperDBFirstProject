using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasAccountsService : CrudService<MgrCanvasAccounts>, IMgrCanvasAccountsService {
        public MgrCanvasAccountsService(IMgrCanvasAccountsRepository repository) : base(repository) {}
    }
}