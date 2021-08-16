using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class UserRoleService
    {
        public readonly IUserRoleRepository _userRoleR;
        public UserRoleService(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }
    }
}
