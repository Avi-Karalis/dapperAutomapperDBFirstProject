using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class SectionContentTranslationsService : CrudService<SectionContentTranslations>, ISectionContentTranslationsService {
        public SectionContentTranslationsService(ISectionContentTranslationsRepository repository) : base(repository) {}
    }
}