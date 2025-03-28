using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class AspNetUserDAO
    {
        private readonly LunaContext _context;
        public AspNetUserDAO(LunaContext context)
        {
            _context = context;
        }
    }
}
