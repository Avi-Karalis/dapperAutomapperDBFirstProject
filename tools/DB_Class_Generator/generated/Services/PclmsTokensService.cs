using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsTokensService : CrudService<PclmsTokens>, IPclmsTokensService {
        public PclmsTokensService(IPclmsTokensRepository repository) : base(repository) {}
    }
}