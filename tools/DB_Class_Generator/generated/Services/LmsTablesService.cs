using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsTablesService : CrudService<LmsTables>, ILmsTablesService {
        public LmsTablesService(ILmsTablesRepository repository) : base(repository) {}
    }
}