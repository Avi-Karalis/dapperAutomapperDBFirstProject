using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;
using AdminPanel.ModelsAndRepository.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
namespace AdminPanel.Service.Services {
    public class UserService : CrudService<User>, IUserService {
        public UserService(IUserRepository repository) : base(repository) {}

        public (string, string) HashPassword(string password) {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount:100000,
                numBytesRequested: 32)
             );

            return (hashedPassword, Convert.ToBase64String(salt));
        }

        public bool ValidatePassword(User user, string password) {
            
            string hashedInput = Convert.ToBase64String(
                KeyDerivation.Pbkdf2(password: password,
                salt: Convert.FromBase64String(user.Salt),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 32)
            );
            return hashedInput == user.PasswordHash;
        }

       
    }
}
