using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.DataAccessLayer.Abstract
{
    public interface IRepository
    {
        Task<int> Save(Customer customer);
        List<Customer> GetAllCustomers();
    }
}
