using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsTaxonomyTranslationsService : CrudService<LmsTaxonomyTranslations>, ILmsTaxonomyTranslationsService {
        public LmsTaxonomyTranslationsService(ILmsTaxonomyTranslationsRepository repository) : base(repository) {}
    }
}