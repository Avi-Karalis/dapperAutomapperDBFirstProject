using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class SessionsService : CrudService<Sessions>, ISessionsService {
        public SessionsService(ISessionsRepository repository) : base(repository) {}
    }
}