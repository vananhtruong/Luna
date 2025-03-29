using LunaBusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class ChatMessageDAO
    {
        private readonly LunaContext _context;
        public ChatMessageDAO(LunaContext context)
        {
            _context = context;
        }
        public List<ChatMessage> getAllMessages()
        {
            return _context.ChatMessages.ToList();
        }
    }
}
