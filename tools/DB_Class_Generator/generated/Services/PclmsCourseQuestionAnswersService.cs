using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseQuestionAnswersService : CrudService<PclmsCourseQuestionAnswers>, IPclmsCourseQuestionAnswersService {
        public PclmsCourseQuestionAnswersService(IPclmsCourseQuestionAnswersRepository repository) : base(repository) {}
    }
}