using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseDiscussionsService : CrudService<LmsCourseDiscussions>, ILmsCourseDiscussionsService {
        public LmsCourseDiscussionsService(ILmsCourseDiscussionsRepository repository) : base(repository) {}
    }
}