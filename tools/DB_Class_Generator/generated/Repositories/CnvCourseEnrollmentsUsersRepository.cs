using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseEnrollmentsUsersRepository : GenericRepository<CnvCourseEnrollmentsUsers>, ICnvCourseEnrollmentsUsersRepository {
        public CnvCourseEnrollmentsUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}