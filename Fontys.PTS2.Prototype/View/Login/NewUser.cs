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

        private void AddSpecificAccountTypes()
        {
            foreach (string AccountType in Enum.GetNames(typeof(User.AccountType)))
            {
                if (AccountType == "Vrijwilliger" || AccountType == "Hulpbehoevende")
                {
                    cbAccountType.Items.Add(AccountType);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbPassword != tbPassValidation)
            {
                MessageBox.Show("Wachtwoord komt niet overeen!");
            }
            else
            {
                if (User.IsEmailValid(tbEmail.Text))
                {
                    QueryUsers.AddNewUser(tbFirstName.Text, tbLastName.Text, dateOfBirth.Value, cboxSex.Text, tbEmail.Text, tbAddress.Text, tbPostalCode.Text, tbCity.Text, tbPassword.Text, cbAccountType.Text);
                }
                else
                {
                    MessageBox.Show("Email is verkeerd!");
                }
            }
        }
    }
}
