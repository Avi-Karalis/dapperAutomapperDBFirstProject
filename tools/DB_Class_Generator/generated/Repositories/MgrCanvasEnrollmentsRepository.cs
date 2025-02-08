using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasEnrollmentsRepository : GenericRepository<MgrCanvasEnrollments>, IMgrCanvasEnrollmentsRepository {
        public MgrCanvasEnrollmentsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}