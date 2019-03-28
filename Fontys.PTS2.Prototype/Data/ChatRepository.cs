using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data.Contexts;

namespace Fontys.PTS2.Prototype.Data
{
    public class ChatRepository
    {
        private IChatContext context;

        public ChatRepository()
        {
            this.context = new ChatContextSQL();
        }

        public ChatRepository(IChatContext context)
        {
            this.context = context;
        }

        public List<ChatLog> GetAllChatsWithVolunteerID(int userid)
        {
            return context.GetAllOpenChatsWithVolunteerID(userid);
        }

        public List<ChatMessage> LoadMessageListWithChatID(int chatID) => context.LoadMessageAsListUsingChatLogID(chatID);

        public void SendMessage(int chatid, int receiverid, int senderid, string message) =>
           context.SendMessage(chatid, receiverid, senderid, message);
    }
}
