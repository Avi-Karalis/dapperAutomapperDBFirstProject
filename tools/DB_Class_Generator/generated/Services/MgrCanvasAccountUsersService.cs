using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasAccountUsersService : CrudService<MgrCanvasAccountUsers>, IMgrCanvasAccountUsersService {
        public MgrCanvasAccountUsersService(IMgrCanvasAccountUsersRepository repository) : base(repository) {}
    }
}