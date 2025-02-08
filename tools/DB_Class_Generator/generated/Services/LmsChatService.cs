using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsChatService : CrudService<LmsChat>, ILmsChatService {
        public LmsChatService(ILmsChatRepository repository) : base(repository) {}
    }
}