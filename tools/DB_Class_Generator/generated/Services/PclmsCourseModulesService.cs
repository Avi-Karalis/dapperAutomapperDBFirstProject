using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseModulesService : CrudService<PclmsCourseModules>, IPclmsCourseModulesService {
        public PclmsCourseModulesService(IPclmsCourseModulesRepository repository) : base(repository) {}
    }
}