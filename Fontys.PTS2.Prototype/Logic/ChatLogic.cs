using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.Logic
{
    class ChatLogic
    {
        ChatRepository chatRepo = new ChatRepository();

        public DataTable GetAllOpenChatsAsDataTable(int userid)
        {
            return GetAllOpenChatsAsDataTable(userid);
        }

        public DataTable LoadMessagesAsDataTable(int chatID)
        {
            return LoadMessagesAsDataTable(chatID);
        }

        public void SendMessage(int chatid, int receiverid, int senderid, string message)
        {
            chatRepo.SendMessage(chatid, receiverid, senderid, message);
        }

        public List<ChatLog> GetAllOpenChatsWithVolunteerID(int userid) => chatRepo.GetAllChatsWithVolunteerID(userid);
    }
}
