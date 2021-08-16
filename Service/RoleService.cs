using CarRentalsSystem.Models;
using CarRentalsSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class RoleService
    {
        public readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public Role AddRole(CreateRoleViewModel model)
        {
            var role = new Role
            {
                Id = model.Id,
                Name = model.Name,
                CreatedAt = DateTime.Now
            };

            return _roleRepository.AddRole(role);
        }
        public Role FindRoleByName(string name)
        {
            return _roleRepository.FindRoleByName(name);
        }
        public Role UpdateRole(UpdateRoleViewModel model)
        {
            var role = new Role
            {
                Id = model.Id,
                Name = model.Name
            };
            return _roleRepository.UpdateRole(role);
        }

        public void DeleteRole(string name)
        {
            _roleRepository.DeleteRole(name);
        }
        public List<RoleViewModel> GetAllRole()
        {
            var category = _roleRepository.GetAllRoles().Select(c => new RoleViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedAt = DateTime.Now

            }).ToList();
            return category;
        }
    }
}
