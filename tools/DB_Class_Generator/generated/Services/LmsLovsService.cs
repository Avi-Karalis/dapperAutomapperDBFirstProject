using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsLovsService : CrudService<LmsLovs>, ILmsLovsService {
        public LmsLovsService(ILmsLovsRepository repository) : base(repository) {}
    }
}