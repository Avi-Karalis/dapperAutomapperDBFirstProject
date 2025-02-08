using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class RolesService : CrudService<Roles>, IRolesService {
        public RolesService(IRolesRepository repository) : base(repository) {}
    }
}