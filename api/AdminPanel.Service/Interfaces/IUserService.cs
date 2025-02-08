using AdminPanel.ModelsAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Service.Interfaces {
    public interface IUserService : ICrudService<User> {
        public (string,string) HashPassword(string password);
        public bool ValidatePassword(User user, string password);

    }
}
