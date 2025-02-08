using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseModulesService : CrudService<CnvCourseModules>, ICnvCourseModulesService {
        public CnvCourseModulesService(ICnvCourseModulesRepository repository) : base(repository) {}
    }
}