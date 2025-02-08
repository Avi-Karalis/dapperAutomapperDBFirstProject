using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseAccountsService : CrudService<LmsCourseAccounts>, ILmsCourseAccountsService {
        public LmsCourseAccountsService(ILmsCourseAccountsRepository repository) : base(repository) {}
    }
}