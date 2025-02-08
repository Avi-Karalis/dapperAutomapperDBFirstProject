using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCompaniesRelService : CrudService<LmsCompaniesRel>, ILmsCompaniesRelService {
        public LmsCompaniesRelService(ILmsCompaniesRelRepository repository) : base(repository) {}
    }
}