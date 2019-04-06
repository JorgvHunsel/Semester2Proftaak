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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAccountOverview_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new AccountOverviewAdminForm());
        }

        private void btnChatLogOverview_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new ChatLogOverviewAdminForm());
        }

        private void btnQuestionOverview_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new QuestionOverviewAdminForm());
        }
    }
}
