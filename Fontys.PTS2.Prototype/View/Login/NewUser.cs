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

namespace Fontys.PTS2.Prototype.View.Login
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            AddGenders();
        }

        private void AddGenders()
        {
            foreach(string gender in Enum.GetNames(typeof(User.Gender)))
            { 
                cboxSex.Items.Add(gender);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User.Gender gender = (User.Gender)Enum.Parse(typeof(User.Gender), cboxSex.Text);
            QueryUsers.AddNewUser(tbFirstName.Text, tbLastName.Text, dateOfBirth, gender, tbEmail.Text, tbAddress.Text, tbPostalCode.Text, tbCity.Text);
        }
    }
}
