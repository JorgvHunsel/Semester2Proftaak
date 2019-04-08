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
    public partial class FormHomeCareRecipient : Form
    {
        User currentUser = LoginPrototype.currentUser;

        public FormHomeCareRecipient()
        {
            InitializeComponent();
        }

        private void FormHomeCareRecipient_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welkom {currentUser.FirstName}";
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new Form1());
        }

        private void btnOpenQuestion_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
        }

        private void btnClosedQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nog niet ingesteld");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new FormUserProfile());
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new LoginPrototype());
        }
    }
}
