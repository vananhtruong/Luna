using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class RoomTypeDAO
    {
        private readonly LunaContext _context;
        public RoomTypeDAO(LunaContext context)
        {
            _context = context;
        }
        public List<RoomType> GetAllRoomTypes()
        {
            return _context.RoomTypes.ToList();
        }
    }
}
