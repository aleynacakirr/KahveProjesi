using KahveProjesi.DataAccessLayer.Concrete;
using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.BusinessLayer.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        Repository _repository = new Repository();
        public virtual async Task Save(Customer customer)
        {
            //Veritabanına kaydeden kodlar yazılacak.
            await _repository.Save(customer);
        }
        public List<Customer> GetAll()
        {
            return _repository.GetAllCustomers();
        }
    }
}
