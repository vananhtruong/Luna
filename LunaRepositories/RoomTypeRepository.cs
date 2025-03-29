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
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly RoomTypeDAO _roomTypeDAO;
        public RoomTypeRepository(RoomTypeDAO roomTypeDAO)
        {
            _roomTypeDAO = roomTypeDAO;
        }
        public List<RoomType> GetAllRoomTypes()
        {
            return _roomTypeDAO.GetAllRoomTypes();
        }
    }
}
