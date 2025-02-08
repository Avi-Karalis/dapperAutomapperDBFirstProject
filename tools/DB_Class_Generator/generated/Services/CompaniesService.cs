using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CompaniesService : CrudService<Companies>, ICompaniesService {
        public CompaniesService(ICompaniesRepository repository) : base(repository) {}
    }
}