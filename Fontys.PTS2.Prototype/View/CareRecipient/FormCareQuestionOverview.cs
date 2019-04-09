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
using Fontys.PTS2.Prototype.View;
using Fontys.PTS2.Prototype.View.CareRecipient;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormCareQuestionOverview : Form
    {

        public FormCareQuestionOverview()
        {
            InitializeComponent();
            List<ListViewItem> items = QuestionLogic.LoadQuestionsToList(QuestionLogic.GetAllOpenQuestionCareRecipientID(FormLogin.currentUser.UserId));

            foreach (ListViewItem item in items)
            {
                lvOpenQuestions.Items.Add(item);
            }
        }

        private void btnFormCareEditQuestion_Click(object sender, EventArgs e)
        {
            
            if (lvOpenQuestions.SelectedItems.Count == 1)
            {
                int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
                int selectedId = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[4].Text);

                ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareEditQuestion(QuestionLogic.GetSingleQuestion(selectedId)));

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareAskQuestion());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareHome());
        }

        private void btnReactions_Click(object sender, EventArgs e)
        {
            int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
            int currentQuestionID = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[4].Text);
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareQuestionReaction(currentQuestionID));            
        }
    }
}
