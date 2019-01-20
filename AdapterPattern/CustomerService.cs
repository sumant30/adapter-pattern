using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AdapterPattern
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICacheStorage _cacheStorage;

        public CustomerService(ICustomerRepository customerRepository, ICacheStorage cacheStorage)
        {
            _customerRepository = customerRepository;
            _cacheStorage = cacheStorage;
        }

        public IList<Customer> GetAllCustomers()
        {
            IList<Customer> customers;
            string storageKey = "GetAllCustomers";
            customers = _cacheStorage.Retrieve<List<Customer>>(storageKey);
            if (customers == null)
            {
                customers = _customerRepository.GetCustomers();
                _cacheStorage.Store(storageKey, customers);
            }

            return customers;
        }
    }
}
