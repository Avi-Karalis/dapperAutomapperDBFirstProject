using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsFoldersService : CrudService<PclmsFolders>, IPclmsFoldersService {
        public PclmsFoldersService(IPclmsFoldersRepository repository) : base(repository) {}
    }
}