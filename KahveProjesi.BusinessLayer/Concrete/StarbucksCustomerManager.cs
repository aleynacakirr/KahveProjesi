using KahveProjesi.BusinessLayer.Abstract;
using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.BusinessLayer.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public Task<bool> CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public override async Task Save(Customer customer)
        {
            //Mernis doğrulaması yap
            if (await _customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Gerçek kişi değil");
            }
           
        }

       
    }
}
