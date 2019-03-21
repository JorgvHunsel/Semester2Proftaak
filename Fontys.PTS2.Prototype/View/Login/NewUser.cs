using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontys.PTS2.Prototype.View.Login
{
    public partial class NewUser : Form
    {
        
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
    }
}
