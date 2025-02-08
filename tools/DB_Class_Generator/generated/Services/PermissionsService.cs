using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PermissionsService : CrudService<Permissions>, IPermissionsService {
        public PermissionsService(IPermissionsRepository repository) : base(repository) {}
    }
}