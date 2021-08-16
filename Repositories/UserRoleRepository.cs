using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class UserRoleRepository
    {
        public readonly RentalsDbContext _dbContext;
        public UserRoleRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserRole AddUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Add(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }

        public List<UserRole> FindUserRoles(int userId)
        {
            return _dbContext.UserRoles.Where(ur => ur.UserId == userId).ToList();
        }
        public UserRole UpdateUserRole(UserRole userrole)
        {
            _dbContext.UserRoles.Update(userrole);
            _dbContext.SaveChanges();
            return userrole;
        }
        /*public void DeleteUserRole(int userId)
        {
            var userrole = FindUserRoles(userId);
            if (userrole != null)
            {
                _dbContext.UserRoles.Remove(userrole);
                _dbContext.SaveChanges();
            }
        }
*/
    }
}
 