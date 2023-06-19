using KahveProjesi.BusinessLayer.Abstract;
using KahveProjesi.BusinessLayer.Adaptors;
using KahveProjesi.BusinessLayer.Concrete;
using KahveProjesi.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using KahveProjesi.WebUI.Models;

namespace KahveProjesi.WebUI.Controllers
{
    public class StarbucksController:Controller
    {
        BaseCustomerManager _customerManager = new StarbucksCustomerManager(new MernisServiceAdaptor());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return View(_customerManager.GetAll());
        }

        [HttpGet]
        public IActionResult StarbucksSave()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> StarbucksSave(Customer customer)
        {
            customer.CompanyName = "Starbucks";
            await _customerManager.Save(customer);
            return RedirectToAction("GetAllCustomers");
        }

    }
}
