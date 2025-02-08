using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseUsersRepository : GenericRepository<CnvCourseUsers>, ICnvCourseUsersRepository {
        public CnvCourseUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}