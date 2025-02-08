using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LanguagesExtService : CrudService<LanguagesExt>, ILanguagesExtService {
        public LanguagesExtService(ILanguagesExtRepository repository) : base(repository) {}
    }
}