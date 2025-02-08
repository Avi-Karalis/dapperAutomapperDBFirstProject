using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseUsersService : CrudService<PclmsCourseUsers>, IPclmsCourseUsersService {
        public PclmsCourseUsersService(IPclmsCourseUsersRepository repository) : base(repository) {}
    }
}