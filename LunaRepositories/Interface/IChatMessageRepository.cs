using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaRepositories.Interface
{
    public interface IChatMessageRepository
    {
        List<ChatMessage> getAllMessages();
    }
}
