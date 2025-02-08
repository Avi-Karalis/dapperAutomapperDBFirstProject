using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsFilesService : CrudService<PclmsFiles>, IPclmsFilesService {
        public PclmsFilesService(IPclmsFilesRepository repository) : base(repository) {}
    }
}