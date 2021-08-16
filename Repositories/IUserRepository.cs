using CarRentalsSystem.Models;
using System.Collections.Generic;

namespace CarRentalsSystem.Repositories
{
    public interface IUserRepository
    {
        public User AddUser(User user);
        public List<UserRole> FindUserRoles(int userId);
        public User FindUserById(int id);
        public void DeleteUser(int id);
        public User UpdateUser(User user);
        public User FindUserByEmail(string email);
    }
}