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
using Fontys.PTS2.Prototype.View.CareRecipient;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormQuestionOverviewCareRecipient : Form
    {

        public FormQuestionOverviewCareRecipient()
        {
            InitializeComponent();
            List<ListViewItem> items = QuestionLogic.LoadQuestionsToList(QuestionLogic.GetAllOpenQuestionCareRecipientID(LoginPrototype.currentUser.UserId));

            foreach (ListViewItem item in items)
            {
                lvOpenQuestions.Items.Add(item);
            }
        }


        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            
            if (lvOpenQuestions.SelectedItems.Count == 1)
            {
                int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
                int selectedId = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[5].Text);

                ((MainForm)this.Parent.Parent).ReplaceForm(new EditQuestion(QuestionLogic.GetSingleQuestion(selectedId)));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new Form1());

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormHomeCareRecipient());
        }

        private void btnReactions_Click(object sender, EventArgs e)
        {
            int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
            int currentQuestionID = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[4].Text);
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormReactionQuestionCareRecipient(currentQuestionID));            
        }
    }
}
