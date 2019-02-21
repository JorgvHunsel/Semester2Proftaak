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
using Fontys.PTS2.Prototype.View;

namespace Fontys.PTS2.Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string urgency = cbUrgent.Checked ? "Urgent" : "NotUrgent";
            Question newQuestion = new Question(tbSubject.Text, tbDescription.Text, Question.QuestionStatus.Open, DateTime.Now, urgency);
            Database db = new Database();
            db.WriteQuestionToDatabase(newQuestion);

            FormQuestionOverview formQuestionOverview = new FormQuestionOverview();
            formQuestionOverview.Show();
        }
    }
}
