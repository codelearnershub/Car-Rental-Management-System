using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public class PaymentRepository
    {
        public readonly RentalsDbContext _dbContext;
        public PaymentRepository(RentalsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Payment Add(Payment payment)
        {
            _dbContext.Payments.Add(payment);
            _dbContext.SaveChanges();
            return payment;
        }
        public Payment FindPaymentById(int id)
        {
            return _dbContext.Payments.Find(id);
        }
        public Payment UpdatePayment(Payment payment)
        {
            _dbContext.Payments.Update(payment);
            _dbContext.SaveChanges();
            return payment;
        }
        public void DeletePayment(int id)
        {

            var payment = FindPaymentById(id);

            if (payment != null)
            {
                _dbContext.Payments.Remove(payment);
                _dbContext.SaveChanges();
            }
        }

        public List<Payment> GetAllPayment()
        {
            return _dbContext.Payments.ToList();
        }
    }
}
