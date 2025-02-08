using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsPermissionsService : CrudService<PclmsPermissions>, IPclmsPermissionsService {
        public PclmsPermissionsService(IPclmsPermissionsRepository repository) : base(repository) {}
    }
}