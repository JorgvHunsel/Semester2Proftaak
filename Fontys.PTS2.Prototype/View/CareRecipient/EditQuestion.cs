using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;
using Fontys.PTS2.Prototype.Logic;

namespace Fontys.PTS2.Prototype.View
{
    public partial class EditQuestion : Form
    {
        private List<Category> categories;
        private Question _question;
        CategoryLogic db = new CategoryLogic();

        public EditQuestion(Question question)
        {
            InitializeComponent();
            _question = question;
            tbContentOld.Text = _question.Content;
            tbSubjectOld.Text = _question.Title;

            foreach (Category category in db.GetAllCategories())
            {
                cmbCategory.Items.Add(category.Name);
            }
        }

        
        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            int categorySelectedIndex = cmbCategory.SelectedIndex;
            string subjectNew;
            string contentNew;
            
            string urgency;
            if(cbUrgent.Checked == true)
            {
                urgency = "Urgent";
            }
            else
            {
                urgency = "Not Urgent";
            }

            subjectNew = (tbSubjectNew.Text == "") ? tbSubjectOld.Text : tbSubjectNew.Text;
            contentNew = (tbContentNew.Text == "") ? tbContentOld.Text : tbContentNew.Text;

            if (categorySelectedIndex == -1)
            {
//                QuestionContextSQL.EditQuestion(questionID, subjectNew, contentNew, urgency);
            }
            else
            {
                Category category = categories[categorySelectedIndex];
//                QuestionContextSQL.EditQuestion(questionID, subjectNew, contentNew, category, urgency);

                //MessageBox.Show("Hulpvraag bewerkt.");
                //((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewVolunteer());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
        }
    }
}
