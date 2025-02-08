using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LanguagesI18nService : CrudService<LanguagesI18n>, ILanguagesI18nService {
        public LanguagesI18nService(ILanguagesI18nRepository repository) : base(repository) {}
    }
}