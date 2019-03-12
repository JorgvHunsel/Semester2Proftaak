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

namespace Fontys.PTS2.Prototype.View
{
    public partial class EditQuestion : Form
    {
        private List<Category> categories;
        private int questionID;
        
        public EditQuestion(int QuestionID)
        {
            InitializeComponent();
            questionID = QuestionID;


            Database db = new Database();
            Question question = db.LoadSingleQuestion(QuestionID);
            tbSubjectOld.Text = question.Title;
            tbContentOld.Text = question.Content;
            tbCategoryOld.Text = question.Category.Name;

            this.categories = db.GetAllCategories();
            foreach (Category category in this.categories)
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

            Database db = new Database();
            if (categorySelectedIndex == -1)
            {
                db.EditQuestion(questionID, subjectNew, contentNew, urgency);
            }
            else
            {
                Category category = categories[categorySelectedIndex];
                db.EditQuestion(questionID, subjectNew, contentNew, category, urgency);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverview());
        }
    }
}
