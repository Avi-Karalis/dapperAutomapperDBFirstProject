using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsAccountUsersService : CrudService<PclmsAccountUsers>, IPclmsAccountUsersService {
        public PclmsAccountUsersService(IPclmsAccountUsersRepository repository) : base(repository) {}
    }
}