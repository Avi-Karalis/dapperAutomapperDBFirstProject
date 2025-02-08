using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CourseTranslationsService : CrudService<CourseTranslations>, ICourseTranslationsService {
        public CourseTranslationsService(ICourseTranslationsRepository repository) : base(repository) {}
    }
}