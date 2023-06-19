using KahveProjesi.BusinessLayer.Abstract;
using KahveProjesi.BusinessLayer.Adaptors;
using KahveProjesi.BusinessLayer.Concrete;
using KahveProjesi.Entities;
using KahveProjesi.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KahveProjesi.WebUI.Controllers
{
    public class PortalController : Controller
    {
        
        BaseCustomerManager _customerManager = new PortalCustomerManager();
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
        public IActionResult PortalSave()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PortalSave(Customer customer)
        {
            customer.CompanyName = "Portal";
            await _customerManager.Save(customer);
            return RedirectToAction("GetAllCustomers");
        }
        
    }
}