using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasUsersService : CrudService<MgrCanvasUsers>, IMgrCanvasUsersService {
        public MgrCanvasUsersService(IMgrCanvasUsersRepository repository) : base(repository) {}
    }
}