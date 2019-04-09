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

namespace Fontys.PTS2.Prototype.View.Volunteer
{
    public partial class FormVolHome : Form
    {
        User currentUser = FormLogin.currentUser;

        public FormVolHome()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormUserProfile());
        }

        private void btnOpenQuestion_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormVolunteerChatOverview());
        }

        private void btnOpenQuestions_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewVolunteer());
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormLogin());

        }

        private void FormHomeVolunteer_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welkom {currentUser.FirstName}";
        }
    }
}
