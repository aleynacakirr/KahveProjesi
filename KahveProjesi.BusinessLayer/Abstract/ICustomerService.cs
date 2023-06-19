using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        Task Save(Customer customer);
    }
}
