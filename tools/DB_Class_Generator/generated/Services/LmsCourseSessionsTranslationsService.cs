using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseSessionsTranslationsService : CrudService<LmsCourseSessionsTranslations>, ILmsCourseSessionsTranslationsService {
        public LmsCourseSessionsTranslationsService(ILmsCourseSessionsTranslationsRepository repository) : base(repository) {}
    }
}