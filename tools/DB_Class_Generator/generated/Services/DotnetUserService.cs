using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class DotnetUserService : CrudService<DotnetUser>, IDotnetUserService {
        public DotnetUserService(IDotnetUserRepository repository) : base(repository) {}
    }
}