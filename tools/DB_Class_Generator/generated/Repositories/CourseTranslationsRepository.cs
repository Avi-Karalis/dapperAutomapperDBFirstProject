using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CourseTranslationsRepository : GenericRepository<CourseTranslations>, ICourseTranslationsRepository {
        public CourseTranslationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}