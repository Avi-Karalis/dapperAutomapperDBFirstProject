using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class ModelHasPermissionsService : CrudService<ModelHasPermissions>, IModelHasPermissionsService {
        public ModelHasPermissionsService(IModelHasPermissionsRepository repository) : base(repository) {}
    }
}