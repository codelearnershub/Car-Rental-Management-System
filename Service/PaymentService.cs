using CarRentalsSystem.Models;
using CarRentalsSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Service
{
    public class PaymentService:IPaymentService
    {

        public readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public Payment AddPayment(CreatePaymentViewModel model)
        {
            var payment = new Payment
            {
                Id = model.Id,
               
                CreatedAt = DateTime.Now
            };

            return _paymentRepository.Add(payment);
        }
        public Payment FindPaymentById(int id)
        {
            return _paymentRepository.FindPaymentById(id);
        }
        public Payment UpdatePayment(UpdatePaymentViewModel model)
        {
            var payment = new Payment
            {
                Id = model.Id,
            
            };
            return _paymentRepository.UpdatePayment(payment);
        }

        public void DeletePayment(int id)
        {
            _paymentRepository.DeletePayment(id);
        }
        public List<PaymentViewModel> GetAllPayment()
        {
            var payment = _paymentRepository.GetAllPayment().Select(c => new PaymentViewModel
            {
                Id = c.Id,
              
                CreatedAt = DateTime.Now

            }).ToList();
            return payment;
        }
    }
}
