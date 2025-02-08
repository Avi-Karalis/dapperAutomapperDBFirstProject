using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsTranslationLanguagesService : CrudService<LmsTranslationLanguages>, ILmsTranslationLanguagesService {
        public LmsTranslationLanguagesService(ILmsTranslationLanguagesRepository repository) : base(repository) {}
    }
}