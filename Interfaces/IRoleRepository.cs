using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
   public interface IRoleRepository
    {
        public Role FindRoleByName(string name);
        public Role AddRole(Role role);
        public List<UserRole> FindUserRoles(int roleId);
        public void DeleteRole(string name);
        public Role UpdateRole(Role role);
        public List<Role> GetAllRoles();
      
    }
}
