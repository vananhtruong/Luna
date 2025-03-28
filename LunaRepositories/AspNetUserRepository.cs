using LunaDataAccessLayer;
using LunaRepositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaRepositories
{
    public class AspNetUserRepository : IAspNetUserRepository
    {
        private readonly AspNetUserDAO _aspNetUserDAO;
        public AspNetUserRepository(AspNetUserDAO aspNetUserDAO)
        {
            _aspNetUserDAO = aspNetUserDAO;
        }
    }
}
