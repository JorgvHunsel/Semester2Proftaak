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
using Fontys.PTS2.Prototype.View;

namespace Fontys.PTS2.Prototype
{
    public partial class Form1 : Form
    {
        private List<Category> categories;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
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
                        Question.QuestionStatus.Open, DateTime.Now, urgency, category);
                    Database db = new Database();
                    db.WriteQuestionToDatabase(newQuestion);

                    MessageBox.Show("De hulpvraag is succesvol aangemaakt");

                    ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverview());

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

        // Button to move to FormQuestionOverview
        private void btnQuestionOverview_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
        }
    }
}
