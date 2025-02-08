using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsRolePermissionsService : CrudService<PclmsRolePermissions>, IPclmsRolePermissionsService {
        public PclmsRolePermissionsService(IPclmsRolePermissionsRepository repository) : base(repository) {}
    }
}