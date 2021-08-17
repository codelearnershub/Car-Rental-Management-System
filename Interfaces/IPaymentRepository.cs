using CarRentalsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Repositories
{
    public interface IPaymentRepository
    {
        public Payment Add(Payment payment);
        public Payment FindPaymentById(int id);
        public Payment UpdatePayment(Payment payment);
        public void DeletePayment(int id);
        public List<Payment> GetAllPayment();
    }
}
