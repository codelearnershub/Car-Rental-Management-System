using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class RoleRepository:IRoleRepository
    {
        public readonly RentalsDbContext _dbContext;
        public RoleRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Role FindRoleByName(string name)
        {
           return _dbContext.Roles.FirstOrDefault(v => v.Name.Equals(name));
        }
        public Role AddRole(Role role)
        {
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return role;
        }

        public List<UserRole> FindUserRoles(int roleId)
        {
            return _dbContext.UserRoles.Where(ur => ur.RoleId == roleId).ToList();
        }

       
        public void DeleteRole(string name)
        {

            var role = FindRoleByName(name);

            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                _dbContext.SaveChanges();
            }
        }
       
        public Role UpdateRole(Role role)
        {
            _dbContext.Roles.Update(role);
            _dbContext.SaveChanges();
            return role;
        }
        public List<Role> GetAllRoles()
        {
            return _dbContext.Roles.ToList();
        }
    }
}
