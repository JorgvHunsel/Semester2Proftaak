using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Data;
using Fontys.PTS2.Prototype.Logic;
using Fontys.PTS2.Prototype.View.Volunteer;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormVolQuestionOverview : Form
    {


        public FormVolQuestionOverview()
        {
            InitializeComponent();
            LoadQuestionsToList();
        }


        public void LoadQuestionsToList()
        {
            DataTable dt = new DataTable();

            dt = QuestionLogic.GetAllOpenQuestions();

            //Adding each row into listview with foreach + for loop
            foreach (DataRow row in dt.Rows)
            {
                //Standard adding item, only add the primary key as main item
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    //each item that follow the primary key will be added as sub item
                    item.SubItems.Add(row[i].ToString());
                }
                lvOpenQuestions.Items.Add(item);
            }
        }

        // Re-open Create Question
        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareAskQuestion());
        }

        // Edit Question
        private void btnEditQuestiFormCareEditQuestionon_Click(object sender, EventArgs e)
        {
            if (lvOpenQuestions.SelectedItems.Count == 1)
            {
                int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
                int selectedId = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[5].Text);
                ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareEditQuestion(QuestionLogic.GetSingleQuestion(selectedId)));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        
        //React to Question
        private void btnReactToQuestion_Click(object sender, EventArgs e)
        {
            
            if (lvOpenQuestions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer eerst een vraag uit de lijst.");
            }
            else
            {
                int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
                int selectedId = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[5].Text);
                

                Form questionReaction = new FormVolQuestionReaction(QuestionLogic.GetSingleQuestion(selectedId));
                questionReaction.Show();
            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormLogin());
        }

        private void ChatOverview_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormVolChatOverview());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormVolHome());

        }
    }
}
