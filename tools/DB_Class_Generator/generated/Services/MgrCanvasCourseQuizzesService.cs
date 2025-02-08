using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasCourseQuizzesService : CrudService<MgrCanvasCourseQuizzes>, IMgrCanvasCourseQuizzesService {
        public MgrCanvasCourseQuizzesService(IMgrCanvasCourseQuizzesRepository repository) : base(repository) {}
    }
}