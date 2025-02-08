using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsTranslationsService : CrudService<LmsTranslations>, ILmsTranslationsService {
        public LmsTranslationsService(ILmsTranslationsRepository repository) : base(repository) {}
    }
}