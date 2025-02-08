using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class RoleHasPermissionsService : CrudService<RoleHasPermissions>, IRoleHasPermissionsService {
        public RoleHasPermissionsService(IRoleHasPermissionsRepository repository) : base(repository) {}
    }
}