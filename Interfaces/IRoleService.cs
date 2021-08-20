using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public interface IRoleService
    {
        public Role AddRole(CreateRoleViewModel model);
        public Role FindRoleByName(string name);
        public void DeleteRole(string name);
        public Role UpdateRole(UpdateRoleViewModel model);
        public List<RoleViewModel> GetAllRole();
    }
}
