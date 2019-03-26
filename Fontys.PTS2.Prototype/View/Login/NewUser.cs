using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            foreach (string gender in Enum.GetNames(typeof(User.Gender)))
            {
                cboxSex.Items.Add(gender);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbPassValidation.Text)
            {
                MessageBox.Show("Wachtwoord komt niet overeen!");
            }
            else
            {
                if (User.IsEmailValid(tbEmail.Text))
                {
                    string accountType = "CareRecipient";
                    if (rbtnVolunteer.Checked)
                    {
                        accountType = "Volunteer";
                    }
                    else if (rbtnCareRecipient.Checked)
                    {
                        accountType = "CareRecipient";
                    }

                    UserContextSQL.AddNewUser(tbFirstName.Text, tbLastName.Text, dateOfBirth.Value, cboxSex.Text, tbEmail.Text, tbAddress.Text, tbPostalCode.Text, tbCity.Text, tbPassword.Text, accountType);
                }
                else
                {
                    MessageBox.Show("Email is verkeerd!");
                }
            }
        }
    }
}
