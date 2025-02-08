using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class SectionContentsService : CrudService<SectionContents>, ISectionContentsService {
        public SectionContentsService(ISectionContentsRepository repository) : base(repository) {}
    }
}