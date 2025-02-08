using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsAccountsBckService : CrudService<PclmsAccountsBck>, IPclmsAccountsBckService {
        public PclmsAccountsBckService(IPclmsAccountsBckRepository repository) : base(repository) {}
    }
}