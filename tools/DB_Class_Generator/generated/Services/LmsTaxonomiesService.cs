using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsTaxonomiesService : CrudService<LmsTaxonomies>, ILmsTaxonomiesService {
        public LmsTaxonomiesService(ILmsTaxonomiesRepository repository) : base(repository) {}
    }
}