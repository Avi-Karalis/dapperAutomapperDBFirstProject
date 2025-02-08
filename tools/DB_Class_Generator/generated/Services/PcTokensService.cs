using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PcTokensService : CrudService<PcTokens>, IPcTokensService {
        public PcTokensService(IPcTokensRepository repository) : base(repository) {}
    }
}