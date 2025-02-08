using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasCoursesBckRepository : GenericRepository<MgrCanvasCoursesBck>, IMgrCanvasCoursesBckRepository {
        public MgrCanvasCoursesBckRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}