using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;
namespace AdminPanel.ModelsAndRepository.Repositories {
    public class UserRepository : GenericRepository<User>, IUserRepository {
        public UserRepository(IDbConnection connection) : base(connection) {
        }

        
    }
}
