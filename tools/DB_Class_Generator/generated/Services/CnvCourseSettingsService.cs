using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseSettingsService : CrudService<CnvCourseSettings>, ICnvCourseSettingsService {
        public CnvCourseSettingsService(ICnvCourseSettingsRepository repository) : base(repository) {}
    }
}