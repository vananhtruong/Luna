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
    public class ChatMessageRepository : IChatMessageRepository
    {
        private readonly ChatMessageDAO _chatMessageDAO;
        public ChatMessageRepository(ChatMessageDAO chatMessageDAO)
        {
            _chatMessageDAO = chatMessageDAO;
        }
        public List<ChatMessage> getAllMessages()
        {
            return _chatMessageDAO.getAllMessages();
        }
    }
}
