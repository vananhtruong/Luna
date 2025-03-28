using LunaBusinessObject;
using LunaDataAccessLayer;
using LunaRepositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaRepositories
{
    public class RoomOrdersRepository : IRoomOrdersRepository
    {
        private readonly RoomOrdersDAO _aspNetUserDAO;
        public RoomOrdersRepository(RoomOrdersDAO aspNetUserDAO)
        {
            _aspNetUserDAO = aspNetUserDAO;
        }
        public List<RoomOrder> GetRoomOrders()
        {
            return _aspNetUserDAO.GetRoomOrders();
        }
    }
}
