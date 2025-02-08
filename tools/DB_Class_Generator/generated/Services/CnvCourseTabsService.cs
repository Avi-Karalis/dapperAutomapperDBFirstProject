using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseTabsService : CrudService<CnvCourseTabs>, ICnvCourseTabsService {
        public CnvCourseTabsService(ICnvCourseTabsRepository repository) : base(repository) {}
    }
}