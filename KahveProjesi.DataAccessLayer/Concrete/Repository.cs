using KahveProjesi.DataAccessLayer.Abstract;
using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.DataAccessLayer.Concrete
{
    public class Repository : IRepository
    {
        KahveContext context = new KahveContext();
        public List<Customer> GetAllCustomers()
        {
            return context.Customers.ToList();
        }

        public async Task<int> Save(Customer customer)
        {
            await context.Customers.AddAsync(customer);
            return await context.SaveChangesAsync();
            
        }
    }
}
