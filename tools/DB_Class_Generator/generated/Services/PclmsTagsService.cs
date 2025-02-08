using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsTagsService : CrudService<PclmsTags>, IPclmsTagsService {
        public PclmsTagsService(IPclmsTagsRepository repository) : base(repository) {}
    }
}