using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsRolesService : CrudService<PclmsRoles>, IPclmsRolesService {
        public PclmsRolesService(IPclmsRolesRepository repository) : base(repository) {}
    }
}