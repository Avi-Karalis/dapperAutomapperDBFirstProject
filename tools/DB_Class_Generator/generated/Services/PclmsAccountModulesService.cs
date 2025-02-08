using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsAccountModulesService : CrudService<PclmsAccountModules>, IPclmsAccountModulesService {
        public PclmsAccountModulesService(IPclmsAccountModulesRepository repository) : base(repository) {}
    }
}