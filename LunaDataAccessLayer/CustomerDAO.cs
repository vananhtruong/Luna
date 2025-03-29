using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class CustomerDAO
    {
        private readonly LunaContext _context;
        public CustomerDAO(LunaContext context)
        {
            _context = context;
        }
        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
