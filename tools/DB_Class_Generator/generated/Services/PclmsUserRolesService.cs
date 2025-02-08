using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsUserRolesService : CrudService<PclmsUserRoles>, IPclmsUserRolesService {
        public PclmsUserRolesService(IPclmsUserRolesRepository repository) : base(repository) {}
    }
}