using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CacheLocksService : CrudService<CacheLocks>, ICacheLocksService {
        public CacheLocksService(ICacheLocksRepository repository) : base(repository) {}
    }
}