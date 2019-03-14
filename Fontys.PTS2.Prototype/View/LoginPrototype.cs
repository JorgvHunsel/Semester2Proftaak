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

namespace Fontys.PTS2.Prototype.View
{

    public partial class LoginPrototype : Form
    {
        private List<string> userNames;

        public LoginPrototype()
        {
            InitializeComponent();
        }

        private void LoginPrototype_Load(object sender, EventArgs e)
        {
            userNames = QueryUsers.GetAllUsers();
            foreach (string FirstName in userNames)
            {
                cboxUsers.Items.Add(FirstName);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbtnCareRecipient.Checked)
            {

            }
            else if (rbtnVolunteer.Checked)
            {

            }
            else
            {
                MessageBox.Show("fa2 niffauw doe rol kiezen");
            }
        }
    }
}
