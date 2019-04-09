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
using Fontys.PTS2.Prototype.Logic;
using Fontys.PTS2.Prototype.View.CareRecipient;
using Fontys.PTS2.Prototype.View.Volunteer;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormUserProfile : Form
    {
        User currentUser = FormLogin.currentUser;

        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Welkom {currentUser.FirstName}";
            tbFirstName.Text = currentUser.FirstName;
            tbLastName.Text = currentUser.LastName;
            tbDateOfBirth.Text = currentUser.BirthDate.ToString();
            dateOfBirth.Value = currentUser.BirthDate;
            tbSex.Text = currentUser.UserGender.ToString();
            tbEmail.Text = currentUser.EmailAddress;
            tbAddress.Text = currentUser.Address;
            tbPostalCode.Text = currentUser.PostalCode;
            tbCity.Text = currentUser.City;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            tbFirstName.ReadOnly = false;
            tbLastName.ReadOnly = false;
            tbDateOfBirth.Visible = false;
            dateOfBirth.Visible = true;
            tbSex.Visible = false;
            cboxSex.Visible = true;
            tbEmail.ReadOnly = false;
            tbAddress.ReadOnly = false;
            tbAddress.ReadOnly = false;
            tbPostalCode.ReadOnly = false;
            tbCity.ReadOnly = false;
            tbPassword.Visible = true;
            tbPassValidation.Visible = true;
            lblPassword.Visible = true;
            lblPaswordValidation.Visible = true;
            btnSave.Visible = true;

            foreach (string gender in Enum.GetNames(typeof(User.Gender)))
            {
                cboxSex.Items.Add(gender);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User currentUser = FormLogin.currentUser;
            if (currentUser.UserAccountType == User.AccountType.CareRecipient)
                ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareQuestionOverview());
            if (currentUser.UserAccountType == User.AccountType.Volunteer)
                ((FormMain)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewVolunteer());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserLogic.IsEmailValid(tbEmail.Text))
            {
                User editUser = new Classes.CareRecipient("a", "b", "c,", "d", "e", "f",
                    Convert.ToDateTime("1988/12/20"), User.Gender.M, true, User.AccountType.CareRecipient);

                string firstname = tbFirstName.Text;
                string lastname = tbLastName.Text;
                string address = tbAddress.Text;
                string city = tbCity.Text;
                string postalCode = tbPostalCode.Text;
                string email = tbEmail.Text;
                DateTime birthdate = dateOfBirth.Value;
                User.Gender gender = (User.Gender)Enum.Parse(typeof(User.Gender), cboxSex.Text);
                string password = tbPassword.Text;
                string passwordValidate = tbPassValidation.Text;

            if (FormLogin.currentUser.UserAccountType == User.AccountType.CareRecipient)
                editUser = new Classes.CareRecipient(FormLogin.currentUser.UserId, firstname, lastname, address, city, postalCode, email, birthdate, gender, true, User.AccountType.CareRecipient);
            else if (FormLogin.currentUser.UserAccountType == User.AccountType.Volunteer)
                editUser = new Classes.Volunteer(FormLogin.currentUser.UserId, firstname, lastname, address, city, postalCode, email, birthdate, gender, true, User.AccountType.Volunteer);

            if (password == passwordValidate)
            {
                UserLogic.EditUser(editUser, password);
                FormLogin.currentUser = editUser;
            }

                else
                {
                    MessageBox.Show("Het wachtwoord komt niet overeen");
                    return;
                }

                btnSave.Visible = false;
                lblTitle.Text = $"Welkom {currentUser.FirstName}";
            }
            else
            {
                MessageBox.Show("Inserted email value is not valid");
            }

        }


    }
}
