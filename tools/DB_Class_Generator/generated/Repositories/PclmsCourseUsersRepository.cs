using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseUsersRepository : GenericRepository<PclmsCourseUsers>, IPclmsCourseUsersRepository {
        public PclmsCourseUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}