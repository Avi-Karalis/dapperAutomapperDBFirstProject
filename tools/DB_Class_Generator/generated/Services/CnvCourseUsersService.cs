using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseUsersService : CrudService<CnvCourseUsers>, ICnvCourseUsersService {
        public CnvCourseUsersService(ICnvCourseUsersRepository repository) : base(repository) {}
    }
}