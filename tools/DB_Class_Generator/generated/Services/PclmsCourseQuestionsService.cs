using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseQuestionsService : CrudService<PclmsCourseQuestions>, IPclmsCourseQuestionsService {
        public PclmsCourseQuestionsService(IPclmsCourseQuestionsRepository repository) : base(repository) {}
    }
}