using KahveProjesi.BusinessLayer.Abstract;
using KahveProjesi.Entities;
using MernisServiceReferance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.BusinessLayer.Adaptors
{
    public class MernisServiceAdaptor : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.Birthday.Year);
            return result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
