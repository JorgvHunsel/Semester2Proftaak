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
using Fontys.PTS2.Prototype.View.Volunteer;

namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    public partial class FormCareRecipientChatOverview : Form
    {
        private List<ChatLog> chatLogs;
        ChatLogic chatLogic = new ChatLogic();

        public FormCareRecipientChatOverview()
        {
            InitializeComponent();
        }
        private void FormCareRecipientChatOverview_Load_1(object sender, EventArgs e)
        {
            chatLogs = chatLogic.GetAllOpenChatsWithCareRecipientID(LoginPrototype.currentUser.UserId);
            for (int i = 0; i < chatLogs.Count; i++)
            {
                ChatLog chatlog = chatLogs[i];

                ListViewItem lvi = new ListViewItem();
                lvi.Text = chatLogs[i].VolunteerFirstName + " " + chatLogs[i].VolunteerLastName;
                lvi.SubItems.Add(chatLogs[i].QuestionTitle.ToString());
                lvi.SubItems.Add(chatlog.TimeStamp.ToString());
                lvi.SubItems.Add(chatlog.ChatLogID.ToString());
                lvi.SubItems.Add(chatlog.VolunteerID.ToString());
                lvi.SubItems.Add(chatlog.QuestionID.ToString());
                lvChats.Items.Add(lvi);
            }
        }

        // Open chat --> FormVolunteerChat.
        private void btnOpenChat_Click_1(object sender, EventArgs e)
        {
            if (lvChats.SelectedItems.Count == 1)
            {
                int selectedRow = lvChats.SelectedItems[0].Index;

                // Parameters
                int selectedChatId = Convert.ToInt32(lvChats.Items[selectedRow].SubItems[3].Text) - 1;
                int receiverID = Convert.ToInt32(lvChats.Items[selectedRow].SubItems[4].Text);
                string selectedName = lvChats.Items[selectedRow].SubItems[0].Text;

                ((MainForm)this.Parent.Parent).ReplaceForm(new FormCareRecipientChat(selectedChatId, selectedName, LoginPrototype.currentUser.UserId, receiverID));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
        }
    }
}