using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class UserRepository:IUserRepository
    {
       
        

            private readonly RentalsDbContext _dbContext;

            public UserRepository(RentalsDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public User AddUser(User user)
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return user;
            }

            public List<UserRole> FindUserRoles(int userId)
            {
                return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
            }

            public User FindUserById(int id)
            {
                return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(id));
            }
        public void DeleteUser(int id)
        {

            var user = FindUserById(id);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
        public User FindUserByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email.Equals(email));
        }

        public User UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }
       



        //public User FindUserById(Guid id)
        //{
        //    return users.FirstOrDefault(user => user.Id == id);
        //}


        //public User FindUserByEmail(string email)
        //{
        //    return users.FirstOrDefault(user => user.Email == email);
        //}

        //public User FindUserByEmailAndPassword(string email, string password)
        //{
        //    return users.FirstOrDefault(user => user.Email == email && user.Password==password);
        //}
    }
    }
