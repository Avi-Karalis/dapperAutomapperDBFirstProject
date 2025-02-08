using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsPagesService : CrudService<PclmsPages>, IPclmsPagesService {
        public PclmsPagesService(IPclmsPagesRepository repository) : base(repository) {}
    }
}