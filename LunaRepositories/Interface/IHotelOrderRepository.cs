using LunaBusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaRepositories.Interface
{
    public interface IHotelOrderRepository
    {
        List<HotelOrder> GetHotelOrders();
    }
}
