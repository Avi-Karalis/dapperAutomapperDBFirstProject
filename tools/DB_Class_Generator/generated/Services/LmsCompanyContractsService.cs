using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCompanyContractsService : CrudService<LmsCompanyContracts>, ILmsCompanyContractsService {
        public LmsCompanyContractsService(ILmsCompanyContractsRepository repository) : base(repository) {}
    }
}