﻿using CarRentalsSystem.Models;
using CarRentalsSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public interface IUserService
    {
        public User LoginUser(string email, string password);

       
        public void RegisterUser(string email, string password, string firstName, string middleName, string lastName, string gender, string phoneNo, DateTime dateOfBirth, string address);
    }
}
