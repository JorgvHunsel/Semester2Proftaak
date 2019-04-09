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

namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    public partial class FormCareHome : Form
    {
        User currentUser = FormLogin.currentUser;

        public FormCareHome()
        {
            InitializeComponent();
        }

        private void FormHomeCareRecipient_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welkom {currentUser.FirstName}";
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareAskQuestion());
        }

        private void btnOpenQuestion_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareQuestionOverview());
        }

        private void btnClosedQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nog niet ingesteld");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormUserProfile());
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormLogin());
        }
    }
}
