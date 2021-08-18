using CarRentalsSystem.Interfaces;
using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        public readonly RentalsDbContext _dbContext;
        public CustomerRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            return customer;
        }
        public Customer UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            return customer;
        }
        public Customer Find(int id)
        {
            return _dbContext.Customers.Find(id);
        }
        public void Delete(int id)
        {
            var customer = Find(id);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
            }       
        }
        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }
    }
    
}
