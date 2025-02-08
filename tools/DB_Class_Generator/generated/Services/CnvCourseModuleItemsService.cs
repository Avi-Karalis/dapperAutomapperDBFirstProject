using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseModuleItemsService : CrudService<CnvCourseModuleItems>, ICnvCourseModuleItemsService {
        public CnvCourseModuleItemsService(ICnvCourseModuleItemsRepository repository) : base(repository) {}
    }
}