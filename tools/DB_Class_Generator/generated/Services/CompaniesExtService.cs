using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CompaniesExtService : CrudService<CompaniesExt>, ICompaniesExtService {
        public CompaniesExtService(ICompaniesExtRepository repository) : base(repository) {}
    }
}