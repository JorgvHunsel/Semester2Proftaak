using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontys.PTS2.Prototype.View.Administrator
{
    public partial class FormAdminHome : Form
    {
        public FormAdminHome()
        {
            InitializeComponent();
        }

        private void btnAccountOverview_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminAccountOverview());
        }

        private void btnChatLogOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nog niet geimplementeerd");
            return;
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminChatLogOverview());
        }

        private void btnQuestionOverview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nog niet geimplementeerd");
            return;
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminQuestionOverview());
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormLogin());
        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminAddProfessional());
        }
    }
}
