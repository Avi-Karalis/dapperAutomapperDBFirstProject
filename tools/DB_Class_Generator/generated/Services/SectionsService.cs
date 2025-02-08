using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class SectionsService : CrudService<Sections>, ISectionsService {
        public SectionsService(ISectionsRepository repository) : base(repository) {}
    }
}