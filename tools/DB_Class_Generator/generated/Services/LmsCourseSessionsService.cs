using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseSessionsService : CrudService<LmsCourseSessions>, ILmsCourseSessionsService {
        public LmsCourseSessionsService(ILmsCourseSessionsRepository repository) : base(repository) {}
    }
}