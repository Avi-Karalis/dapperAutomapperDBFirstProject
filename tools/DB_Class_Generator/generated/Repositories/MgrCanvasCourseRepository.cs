using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasCourseRepository : GenericRepository<MgrCanvasCourse>, IMgrCanvasCourseRepository {
        public MgrCanvasCourseRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}