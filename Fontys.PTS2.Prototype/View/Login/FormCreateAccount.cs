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
using Fontys.PTS2.Prototype.Logic;

namespace Fontys.PTS2.Prototype.View.Login
{
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
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
                if (UserLogic.CheckIfUserAlreadyExists(tbEmail.Text))
                {
                    if (UserLogic.IsEmailValid(tbEmail.Text))
                    {
                        string accountType = "CareRecipient";
                        if (rbtnVolunteer.Checked)
                        {
                            Classes.Volunteer currentUser = new Classes.Volunteer(tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbCity.Text, tbPostalCode.Text, tbEmail.Text, dateOfBirth.Value, (User.Gender)Enum.Parse(typeof(User.Gender), cboxSex.Text), true, User.AccountType.Volunteer);
                            UserLogic.AddNewUser(currentUser, tbPassword.Text);
                        }
                        else if (rbtnCareRecipient.Checked)
                        {
                            Classes.CareRecipient currentUser = new Classes.CareRecipient(tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbCity.Text, tbPostalCode.Text, tbEmail.Text, dateOfBirth.Value, (User.Gender)Enum.Parse(typeof(User.Gender), cboxSex.Text), true, User.AccountType.CareRecipient);
                            UserLogic.AddNewUser(currentUser, tbPassword.Text);
                        }
                        ((FormMain) this.Parent.Parent).ReplaceForm(new FormLogin());
                    }
                    else
                    {
                        MessageBox.Show("Email is verkeerd!");
                    }
                }
                else
                {
                    MessageBox.Show("Gebruiker bestaat al!");
                }
            }            
        }
    }
}
