using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseEnrollmentsRepository : GenericRepository<CnvCourseEnrollments>, ICnvCourseEnrollmentsRepository {
        public CnvCourseEnrollmentsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}