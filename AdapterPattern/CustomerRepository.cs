using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class CustomerRepository : ICustomerRepository
    {
        public IList<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Name = "Sumant"},
                new Customer() {Name = "Gene wolfe"}
            };
        }
    }
}
