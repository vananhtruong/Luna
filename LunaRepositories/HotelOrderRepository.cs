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
    public class HotelOrderRepository : IHotelOrderRepository
    {
        private readonly HotelOrderDAO _aspNetUserDAO;
        public HotelOrderRepository(HotelOrderDAO aspNetUserDAO)
        {
            _aspNetUserDAO = aspNetUserDAO;
        }
        public List<HotelOrder> GetHotelOrders()
        {
            return _aspNetUserDAO.GetHotelOrders();
        }
    }
}
