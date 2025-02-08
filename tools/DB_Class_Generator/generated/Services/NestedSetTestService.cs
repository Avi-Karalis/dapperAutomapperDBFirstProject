using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class NestedSetTestService : CrudService<NestedSetTest>, INestedSetTestService {
        public NestedSetTestService(INestedSetTestRepository repository) : base(repository) {}
    }
}