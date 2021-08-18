using CarRentalsSystem.Interfaces;
using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using CarRentalsSystem.Repositories;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;
        public readonly ICustomerRepository customerRepository;
        public readonly IRoleRepository roleRepository;
        public UserService(IUserRepository userRepository, IRoleRepository roleRepository, ICustomerRepository customerRepository)
        {
            _userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.customerRepository = customerRepository;
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
        /*   public void RegisterCustomer(RegisterViewModel model)
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
   */
        


        //}

        public void RegisterUser(RegisterViewModel model)
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string saltString = Convert.ToBase64String(salt);

            string hashedPassword = HashPassword(model.Password, saltString);


            User user = new User
            {
                Id = model.Id,
                ConfirmPassword = model.ConfirmPassword,
                Email= model.Email,
                HashSalt = saltString,
                PasswordHash = hashedPassword,
                Role = roleRepository.FindRoleByName("Admin")
            };
            _userRepository.AddUser(user);
            Customer customer = new Customer
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
            customerRepository.AddCustomer(customer);
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





        //customerservice.addcustomer(customer);

        ////////    admin admin = new admin
        ////////    {
        ////////        userid = user.id,
        ////////        firstname = firstname,
        ////////        middlename = middlename,
        ////////        lastname = lastname,
        ////////        gender = gender,
        ////////        email = email,
        ////////        phoneno = phoneno,
        ////////        dateofbirth = dateofbirth,
        ////////        address = "abeokuta"
        ////////    };

        ////////adminservice.addadmin(admin);




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
