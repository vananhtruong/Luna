using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class RoomOrdersDAO
    {
        private readonly LunaContext _context;
        public RoomOrdersDAO(LunaContext context)
        {
            _context = context;
        }
        public List<RoomOrder> GetRoomOrders()
        {
            return _context.RoomOrders.ToList();
        }
    }
}
