using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvAccountUsersService : CrudService<CnvAccountUsers>, ICnvAccountUsersService {
        public CnvAccountUsersService(ICnvAccountUsersRepository repository) : base(repository) {}
    }
}