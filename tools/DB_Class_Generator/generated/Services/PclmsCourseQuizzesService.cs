using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseQuizzesService : CrudService<PclmsCourseQuizzes>, IPclmsCourseQuizzesService {
        public PclmsCourseQuizzesService(IPclmsCourseQuizzesRepository repository) : base(repository) {}
    }
}