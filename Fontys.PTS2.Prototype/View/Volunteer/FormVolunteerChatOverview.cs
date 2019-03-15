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
using Fontys.PTS2.Prototype.View.Volunteer;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormVolunteerChatOverview : Form
    {
        private List<ChatLog> chatLogs;
        // Logged in user
        private User user;
        private string receiverName = "Willem";

        public FormVolunteerChatOverview()
        {
            InitializeComponent();
        }

        // Load listview with items. @@@@@@@@ ADD DATETIME IN DB @@@@@@@@
        private void FormVolunteerChatOverview_Load(object sender, EventArgs e)
        {
            chatLogs = GetAllOpenChatsAsList();
            for (int i = 0; i < chatLogs.Count; i++)
            {
                ChatLog chatlog = chatLogs[i];
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = chatLogs[i].ReceiverFirstName + " " + chatLogs[i].ReceiverLastName;
                lvi.SubItems.Add(chatLogs[i].QuestionTitle.ToString());
                lvi.SubItems.Add("Nog toe te voegen.");
                lvi.SubItems.Add(chatlog.ChatLogID.ToString());
                lvi.SubItems.Add(chatlog.ReceiverID.ToString());
                lvChats.Items.Add(lvi);
            }
        }

        // Open chat --> FormVolunteerChat.
        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            if (lvChats.SelectedItems.Count == 1)
            {
                int selectedRow = lvChats.SelectedItems[0].Index;
                int selectedChatId = Convert.ToInt32(lvChats.Items[selectedRow].SubItems[3].Text);

                int receiverID = Convert.ToInt32(lvChats.Items[selectedRow].SubItems[4].Text);

                string selectedName = lvChats.Items[selectedRow].SubItems[0].Text;
                ((MainForm)this.Parent.Parent).ReplaceForm(new FormVolunteerChat(chatLogs[selectedChatId].ChatLogID));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        // Convert DataTable to List.
        private List<ChatLog> GetAllOpenChatsAsList()
        {
            DatabaseChat dbchat = new DatabaseChat();
            DataTable dt = dbchat.GetAllOpenChatsAsDataTable();

            List<ChatLog> chatLogList = new List<ChatLog>();

            foreach (DataRow row in dt.Rows)
            {
                int chatLogID = Convert.ToInt32(row["ChatLogID"].ToString());
                string questionTitle = row["QuestionTitle"].ToString();
                int senderID = Convert.ToInt32(row["SenderID"].ToString());
                int receiverID = Convert.ToInt32(row["ReceiverID"].ToString());
                string receiverLastName = row["ReceiverLastName"].ToString();
                string receiverFirstName = row["ReceiverFirstName"].ToString();
                string senderLastName = row["SenderLastName"].ToString();
                string senderFirstName = row["SenderFirstName"].ToString();

                ChatLog chatLog = new ChatLog(chatLogID, questionTitle, senderID, receiverID, receiverLastName, receiverFirstName, senderLastName, senderFirstName);
                chatLogList.Add(chatLog);
            }

            return chatLogList;
        }
    }
}
