using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Repositories;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace CarRentalsSystem.Service
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;
      
        public readonly IRoleRepository roleRepository;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public User LoginUser(string email, string password)
        {
            User user = _userRepository.FindUserByEmail(email);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            string hashedPassword = HashPassword(password, user.HashSalt);

            if (user.PasswordHash.Equals(hashedPassword))
            {
                Console.WriteLine("User is found");
                return user;
            }

            return null;
        }
        public void RegisterCustomer(RegisterViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);

            var role = roleRepository.FindRoleByName("Customer");
            User user = new User
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Gender = model.Gender,
                DateOfBirth = model.DateOfBirth,
                PhoneNo = model.PhoneNo,
                Address = model.Address,
                Email = model.Email,
            };
            var userRole = new UserRole
            {
                User = user,
                UserId = user.Id,
                Role = role,
                RoleId = role.Id,
            };
            user.UserRoles.Add(userRole);

            
        }

            public void RegisterUser(RegisterViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.ConfirmPassword, saltString);

            var role = roleRepository.FindRoleByName("Customer");

            User user = new User
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Gender = model.Gender,
                DateOfBirth = model.DateOfBirth,
                PhoneNo = model.PhoneNo,
                Address = model.Address,
                Email = model.Email,
                PasswordHash = hashedPassword,
                HashSalt = saltString,
            };
            //Role role = new Role();
          /*  var role = roleRepository.FindRoleByName("");*/
            var userRole = new UserRole
            {
                User = user,
                UserId = 2,
                Role = role,
                RoleId = role.Id,
            };
            user.UserRoles.Add(userRole);
            _userRepository.AddUser(user);
            //user.UserRoles.Add(userRole);
            /* Customer customer = new Customer
             {
                 UserId = model.Id,
                 FirstName = model.FirstName,
                 MiddleName = model.MiddleName,
                 LastName = model.LastName,
                 Gender = model.Gender,
                 Email = model.Email,

                 PhoneNo = model.PhoneNo,
                 DateOfBirth = model.DateOfBirth,
                 Address = model.Address,
             };
             customerRepository.AddCustomer(customer);*/
            /*  Admin admin = new Admin
              {
                  UserId = model.Id,
                  FirstName = model.FirstName,
                  MiddleName = model.MiddleName,
                  LastName = model.LastName,
                  Gender = model.Gender,
                  Email = model.Email,
                  PhoneNo = model.Password,
                  DateOfBirth = model.DateOfBirth,
                  Address = "abeokuta"
              };*/

            //////adminservice.addadmin(admin);
            /*foreach(var role in model.Roles)
            {
                var userRole = new UserRole
                {
                    User = user,
                    UserId = user.Id,
                    Role = role,
                    RoleId = role.Id,
                };
                user.UserRoles.Add(userRole);*/
        }












        private string HashPassword(string password, string salt)
        {
            byte[] saltByte = Convert.FromBase64String(salt);
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");

            return hashed;
        }
    }
}
