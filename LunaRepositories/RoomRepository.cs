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
    public class RoomRepository : IRoomRepository
    {
        private readonly RoomDAO _roomDAO;
        public RoomRepository(RoomDAO roomDAO)
        {
            _roomDAO = roomDAO;
        }
        public List<Room> GetAllRooms()
        {
            return _roomDAO.GetAllRooms();
        }
    }
}
