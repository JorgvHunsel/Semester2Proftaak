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

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormVolunteerChatOverview : Form
    {
        private List<ChatLog> chatLogs;
        // Logged in user
        private int userid = 15;
        ChatLogic chatLogic = new ChatLogic();

        public FormVolunteerChatOverview()
        {
            InitializeComponent();
        }

        // Load listview with items.
        private void FormVolunteerChatOverview_Load(object sender, EventArgs e)
        {
            
            chatLogs = chatLogic.GetAllOpenChatsWithVolunteerID(userid);
            for (int i = 0; i < chatLogs.Count; i++)
            {
                ChatLog chatlog = chatLogs[i];
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = chatLogs[i].CareRecipientFirstName + " " + chatLogs[i].CareRecipientLastName;
                lvi.SubItems.Add(chatLogs[i].QuestionTitle.ToString());
                lvi.SubItems.Add(chatlog.TimeStamp.ToString());
                lvi.SubItems.Add(chatlog.ChatLogID.ToString());
                lvi.SubItems.Add(chatlog.CareRecipientID.ToString());
                lvChats.Items.Add(lvi);
            }
        }

        // Open chat --> FormVolunteerChat.
        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            if (lvChats.SelectedItems.Count == 1)
            {
                int selectedRow = lvChats.SelectedItems[0].Index;
                int selectedChatId = Convert.ToInt32(lvChats.Items[selectedRow].SubItems[3].Text) -1;

                int receiverID = Convert.ToInt32(lvChats.Items[selectedRow].SubItems[4].Text);

                string selectedName = lvChats.Items[selectedRow].SubItems[0].Text;
                
                ((MainForm)this.Parent.Parent).ReplaceForm(new FormVolunteerChat(selectedChatId, lvChats.Items[selectedRow].SubItems[0].Text, userid));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewVolunteer());
        }
    }
}
