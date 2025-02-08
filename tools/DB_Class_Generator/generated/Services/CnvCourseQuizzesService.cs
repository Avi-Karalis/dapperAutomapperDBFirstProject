using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseQuizzesService : CrudService<CnvCourseQuizzes>, ICnvCourseQuizzesService {
        public CnvCourseQuizzesService(ICnvCourseQuizzesRepository repository) : base(repository) {}
    }
}