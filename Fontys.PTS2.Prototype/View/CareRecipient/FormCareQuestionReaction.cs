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
using Fontys.PTS2.Prototype.Logic;

namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    public partial class FormCareQuestionReaction : Form
    {
        private int _questionID;

        public FormCareQuestionReaction(int questionID)
        {
            InitializeComponent();
            _questionID = questionID;
            List<ListViewItem> items = ReactionLogic.LoadReactionsToList(ReactionLogic.GetAllCommentsWithQuestionID(_questionID));

            foreach (ListViewItem item in items)
            {
                lvQuestionReaction.Items.Add(item);
            }


        }

        private void btnCreateChatlog_Click(object sender, EventArgs e)
        {

            if (lvQuestionReaction.SelectedItems.Count == 1)
            {
                int selectedRow = lvQuestionReaction.SelectedItems[0].Index;
                int selectedId = Convert.ToInt32(lvQuestionReaction.Items[selectedRow].SubItems[3].Text);
                int reactionID = Convert.ToInt32(lvQuestionReaction.Items[selectedRow].SubItems[4].Text);
                int senderID = Convert.ToInt32(lvQuestionReaction.Items[selectedRow].SubItems[5].Text);

                ChatLogic cl = new ChatLogic();
                cl.CreateNewChatLog(reactionID, senderID, FormLogin.currentUser.UserId);
                MessageBox.Show("Chat aangemaakt");
                ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareChatOverview());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareHome());
        }
    }
}
