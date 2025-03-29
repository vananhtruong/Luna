using LunaBusinessObject;
using LunaDataAccessLayer;
using LunaRepositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaRepositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDAO _customerDAO;
        public CustomerRepository(CustomerDAO customerDAO)
        {
            _customerDAO = customerDAO;
        }
        public List<Customer> GetAllCustomers()
        {
            return _customerDAO.GetAllCustomers();
        }
    }
}
