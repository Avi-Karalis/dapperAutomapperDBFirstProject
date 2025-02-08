using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class SectionTranslationsService : CrudService<SectionTranslations>, ISectionTranslationsService {
        public SectionTranslationsService(ISectionTranslationsRepository repository) : base(repository) {}
    }
}