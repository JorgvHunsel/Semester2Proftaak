using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;
using Fontys.PTS2.Prototype.Logic;
using Fontys.PTS2.Prototype.View;
using Fontys.PTS2.Prototype.View.CareRecipient;

namespace Fontys.PTS2.Prototype
{
    public partial class FormCareAskQuestion : Form
    {
        private List<Category> categories;


        public FormCareAskQuestion()
        {
            InitializeComponent();
        }

        private void FormCareAskQuestion_Load(object sender, EventArgs e)
        {
            CategoryLogic db = new CategoryLogic();
            this.categories = db.GetAllCategories();
            foreach (Category category in categories)
            {
                cboxCategory.Items.Add(category.Name);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (CategoryComboboxIsNotEmpty() == true && SubmittedValuesNotEmpty() == true)
            {
                int categorySelectedIndex = cboxCategory.SelectedIndex;

                try
                {
                    Category category = categories[categorySelectedIndex];
                    string urgency = cbUrgent.Checked ? "Urgent" : "NotUrgent";
                    Question newQuestion = new Question(tbSubject.Text, tbDescription.Text,
                        Question.QuestionStatus.Open, DateTime.Now, urgency, category, LoginPrototype.currentUser.UserId);
                    QuestionLogic.WriteQuestionToDatabase(newQuestion);

                    MessageBox.Show("De hulpvraag is succesvol aangemaakt");

                    ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareQuestionOverview());

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Categorie fout.");
                }

            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }


        private bool SubmittedValuesNotEmpty()
        {
            if (tbSubject.Text != "" | tbDescription.Text != "")
            {
                return true;
            }
            return false;
        }


        private bool CategoryComboboxIsNotEmpty()
        {
            if (cboxCategory.SelectedText == "")
            {
                return true;
            }

            return false;
        }

        // Button to move to FormQuestionOverviewVolunteer
        private void btnQuestionOverview_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareHome());
        }
    }
}
