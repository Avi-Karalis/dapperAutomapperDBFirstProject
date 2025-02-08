using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvGradebookFeedService : CrudService<CnvGradebookFeed>, ICnvGradebookFeedService {
        public CnvGradebookFeedService(ICnvGradebookFeedRepository repository) : base(repository) {}
    }
}