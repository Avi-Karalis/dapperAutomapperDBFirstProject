using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseSessionAccountsService : CrudService<LmsCourseSessionAccounts>, ILmsCourseSessionAccountsService {
        public LmsCourseSessionAccountsService(ILmsCourseSessionAccountsRepository repository) : base(repository) {}
    }
}