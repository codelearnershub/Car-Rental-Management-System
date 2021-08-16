using CarRentalsSystem.Models;
using System.Collections.Generic;

namespace CarRentalsSystem.Service
{
    public interface IPaymentService
    {
        public Payment AddPayment(CreatePaymentViewModel model);
        public Payment FindPaymentById(int id);
        public Payment UpdatePayment(UpdatePaymentViewModel model);
        public void DeletePayment(int id);
        public List<PaymentViewModel> GetAllPayment();
    }
}