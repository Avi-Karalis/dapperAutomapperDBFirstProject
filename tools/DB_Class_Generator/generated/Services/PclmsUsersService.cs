using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsUsersService : CrudService<PclmsUsers>, IPclmsUsersService {
        public PclmsUsersService(IPclmsUsersRepository repository) : base(repository) {}
    }
}