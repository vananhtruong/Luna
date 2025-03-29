using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class RoomDAO
    {
        private readonly LunaContext _context;
        public RoomDAO(LunaContext context)
        {
            _context = context;
        }
        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }
    }
}
