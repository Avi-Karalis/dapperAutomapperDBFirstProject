using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LanguagesService : CrudService<Languages>, ILanguagesService {
        public LanguagesService(ILanguagesRepository repository) : base(repository) {}
    }
}