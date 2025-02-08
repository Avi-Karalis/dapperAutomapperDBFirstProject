using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasCoursesTempRepository : GenericRepository<MgrCanvasCoursesTemp>, IMgrCanvasCoursesTempRepository {
        public MgrCanvasCoursesTempRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}