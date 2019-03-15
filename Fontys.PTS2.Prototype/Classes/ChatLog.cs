using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontys.PTS2.Prototype.Classes
{
    class ChatLog
    {
        public int ChatLogID { get; private set; }
        public string QuestionTitle { get; private set; }
        public int SenderID { get; }
        public int ReceiverID { get; }
        public string ReceiverLastName { get; private set; }
        public string ReceiverFirstName { get; private set; }
        public string SenderLastName { get; private set; }
        public string SenderFirstName { get; private set; }
        public List<ChatMessage> Messages = new List<ChatMessage>();

        public ChatLog(int chatLogId, string questionTitle, int senderId, int receiverId, string receiverLastName, string receiverFirstName, string senderLastName, string senderFirstName)
        {
            ChatLogID = chatLogId;
            QuestionTitle = questionTitle;
            SenderID = senderId;
            ReceiverID = receiverId;
            ReceiverLastName = receiverLastName;
            ReceiverFirstName = receiverFirstName;
            SenderLastName = senderLastName;
            SenderFirstName = senderFirstName;
        }
    }
}
