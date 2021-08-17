using CarRentalsSystem.Models;
using CarRentalsSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsSystem.Controllers
{
    public class PaymentController : Controller
    {
        public readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public IActionResult Index()
        {
            var payment = _paymentService.GetAllPayment();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(CreatePaymentViewModel model)
        {
           _paymentService.AddPayment(model);
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Update (UpdatePaymentViewModel model)
        {
            _paymentService.UpdatePayment(model);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Find(int id)
        {
            _paymentService.FindPaymentById(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _paymentService.DeletePayment(id);
            return RedirectToAction("Index");
        }
    }
}
