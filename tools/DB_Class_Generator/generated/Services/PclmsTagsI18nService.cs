using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsTagsI18nService : CrudService<PclmsTagsI18n>, IPclmsTagsI18nService {
        public PclmsTagsI18nService(IPclmsTagsI18nRepository repository) : base(repository) {}
    }
}