using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Data.Contexts
{
    public interface IChatContext
    {
        DataTable GetAllOpenChatsAsDataTable(int userid);
        DataTable LoadMessagesAsDataTable(int chatID);
        void SendMessage(int chatid, int receiverid, int senderid, string message);
    }
}
