using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Interfaces
{
    public interface ICustomerRepository
    {
        public Customer AddCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer);
        public Customer Find(int id);
        public void Delete(int id);
        public List<Customer> GetAllCustomers();
    }
}
