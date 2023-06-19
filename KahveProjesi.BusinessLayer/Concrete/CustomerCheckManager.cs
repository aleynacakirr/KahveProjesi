using KahveProjesi.BusinessLayer.Abstract;
using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.BusinessLayer.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
