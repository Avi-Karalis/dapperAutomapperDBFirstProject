using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseAttachmentsI18nService : CrudService<LmsCourseAttachmentsI18n>, ILmsCourseAttachmentsI18nService {
        public LmsCourseAttachmentsI18nService(ILmsCourseAttachmentsI18nRepository repository) : base(repository) {}
    }
}