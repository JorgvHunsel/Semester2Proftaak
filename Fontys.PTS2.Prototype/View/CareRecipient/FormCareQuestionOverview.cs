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
        QuestionLogic ql = new QuestionLogic();

        public FormCareQuestionOverview()
        {
            InitializeComponent();
            LoadQuestionsToList();
        }

        public void LoadQuestionsToList()
        {
            DataTable dt = QuestionLogic.GetAllOpenQuestionCareRecipientID(FormLogin.currentUser.UserId);

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
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
    }
}
