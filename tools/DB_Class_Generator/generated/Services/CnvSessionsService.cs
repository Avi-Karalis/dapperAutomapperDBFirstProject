using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvSessionsService : CrudService<CnvSessions>, ICnvSessionsService {
        public CnvSessionsService(ICnvSessionsRepository repository) : base(repository) {}
    }
}