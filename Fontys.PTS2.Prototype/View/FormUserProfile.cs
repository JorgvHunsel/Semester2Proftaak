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

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormUserProfile : Form
    {
        //UserLogic ul = new UserLogic();
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {

            User currentUser = LoginPrototype.currentUser;

            lblTitle.Text = $"Welkom {currentUser.FirstName}";
            tbFirstName.Text = currentUser.FirstName;
            tbLastName.Text = currentUser.LastName;
            tbDateOfBirth.Text = currentUser.DateTime.ToString();
            dateOfBirth.Value = currentUser.DateTime;
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

            foreach (string gender in Enum.GetNames(typeof(User.Gender)))
            {
                cboxSex.Items.Add(gender);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User currentUser = LoginPrototype.currentUser;
            if(currentUser.UserAccountType == User.AccountType.CareRecipient)
                ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
            if(currentUser.UserAccountType == User.AccountType.Volunteer)
                ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewVolunteer());
        }
    }
}
