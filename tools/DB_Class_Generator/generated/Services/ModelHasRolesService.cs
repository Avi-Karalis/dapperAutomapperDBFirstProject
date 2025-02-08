using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class ModelHasRolesService : CrudService<ModelHasRoles>, IModelHasRolesService {
        public ModelHasRolesService(IModelHasRolesRepository repository) : base(repository) {}
    }
}