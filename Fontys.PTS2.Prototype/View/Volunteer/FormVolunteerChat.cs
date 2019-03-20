using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;
using Microsoft.Win32;
using Message = System.Windows.Forms.Message;

namespace Fontys.PTS2.Prototype.View.Volunteer
{
    public partial class FormVolunteerChat : Form
    {
        private int chatID;
        private int SenderID = 3;
        private int receiverID = 1;

        public FormVolunteerChat(int chatID)
        {
            InitializeComponent();
            this.chatID = chatID;
        }

        private void FormVolunteerChat_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text;

            DatabaseChat dbChat = new DatabaseChat();
            dbChat.SendMessage(this.chatID, 3, 1, message);
            RefreshPage();
        }

        private List<ChatMessage> LoadMessagesAsList()
        {
            DatabaseChat dbChat = new DatabaseChat();
            DataTable messagesDataTable = dbChat.LoadMessagesAsDataTable(chatID);

            List<ChatMessage> messagesList = new List<ChatMessage>();

            foreach (DataRow row in messagesDataTable.Rows)
            {
                int ChatID = Convert.ToInt32(row["ChatID"].ToString());
                int SenderID = Convert.ToInt32(row["SenderID"].ToString());
                int ReceiverID = Convert.ToInt32(row["ReceiverID"].ToString());
                string Content = row["Content"].ToString();
                DateTime timestamp = Convert.ToDateTime(row["TimeStamp"]);

                ChatMessage message = new ChatMessage(ChatID, SenderID, ReceiverID, Content, timestamp);
                messagesList.Add(message);
            }

            return messagesList;
        }

        private void RefreshPage()
        {
            lbChat.Items.Clear();
            List<ChatMessage> messagesList = LoadMessagesAsList();

            for (int i = 0; i < messagesList.Count; i++)
            {
                if (messagesList[i].ReceiverID == this.receiverID)
                {
                    lbChat.Items.Add("You: " + messagesList[i].MessageContent);
                }
                else
                {
                    lbChat.Items.Add("Other: " + messagesList[i].MessageContent);
                }
            }
        }
    }
}
