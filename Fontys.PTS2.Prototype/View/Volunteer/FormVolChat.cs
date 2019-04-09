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
using Fontys.PTS2.Prototype.Logic;
using Microsoft.Win32;
using Message = System.Windows.Forms.Message;

namespace Fontys.PTS2.Prototype.View.Volunteer
{
    public partial class FormVolChat : Form
    {
        private int chatID;

        // Logged in User
        private int senderID;
        private int receiverID;
        private string chatReceiver;
        private ChatLogic chatLogic = new ChatLogic();

        public FormVolChat(int chatID, string chatReceiver, int userID, int receiverID)
        {
            InitializeComponent();
            this.chatID = chatID;
            this.chatReceiver = chatReceiver;
            this.senderID = userID;
            this.receiverID = receiverID;
        }

        private void FormVolunteerChat_Load(object sender, EventArgs e)
        {
            RefreshPage();
            lbChatReceiver.Text = chatReceiver;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string message = tbMessage.Text;
            
            chatLogic.SendMessage(this.chatID,receiverID, senderID, message);
            RefreshPage();
        }
        
        // Refresh latest messages
        private void RefreshPage()
        {
            lbChat.Items.Clear();
            List<ChatMessage> messageList = chatLogic.LoadMessageListWithChatID(chatID);

            for (int i = 0; i < messageList.Count; i++)
            {
                if (messageList[i].ReceiverID == this.receiverID)
                {
                    lbChat.Items.Add("You: " + messageList[i].MessageContent);
                }
                else
                {
                    lbChat.Items.Add("Other: " + messageList[i].MessageContent);
                }
            }
        }

        private void btnBackToChats_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormVolunteerChatOverview());
        }
    }
}
