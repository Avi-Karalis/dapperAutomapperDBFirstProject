using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsPositionRolesService : CrudService<LmsPositionRoles>, ILmsPositionRolesService {
        public LmsPositionRolesService(ILmsPositionRolesRepository repository) : base(repository) {}
    }
}