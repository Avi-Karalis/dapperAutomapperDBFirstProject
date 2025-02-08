using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CompanyUsersService : CrudService<CompanyUsers>, ICompanyUsersService {
        public CompanyUsersService(ICompanyUsersRepository repository) : base(repository) {}
    }
}