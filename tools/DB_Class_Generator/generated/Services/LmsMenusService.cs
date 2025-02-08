using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsMenusService : CrudService<LmsMenus>, ILmsMenusService {
        public LmsMenusService(ILmsMenusRepository repository) : base(repository) {}
    }
}