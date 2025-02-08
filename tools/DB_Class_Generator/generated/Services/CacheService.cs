using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CacheService : CrudService<Cache>, ICacheService {
        public CacheService(ICacheRepository repository) : base(repository) {}
    }
}