using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class HotelOrderDAO
    {
        private readonly LunaContext _context;
        public HotelOrderDAO(LunaContext context)
        {
            _context = context;
        }
        public List<HotelOrder> GetHotelOrders()
        {
            return _context.HotelOrders.ToList();
        }
    }
}
