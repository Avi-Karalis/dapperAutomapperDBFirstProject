using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasCoursesRepository : GenericRepository<MgrCanvasCourses>, IMgrCanvasCoursesRepository {
        public MgrCanvasCoursesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}