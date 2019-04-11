using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Logic;
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
using Fontys.PTS2.Prototype.Logic;


namespace Fontys.PTS2.Prototype.View.Administrator
{
    public partial class FormAdminAddProfessional : Form
    {
        public FormAdminAddProfessional()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User newProfessional = new Professional(tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbCity.Text, tbPostalCode.Text, tbEmail.Text, dateOfBirth.Value, (User.Gender)Enum.Parse(typeof(User.Gender), cboxSex.Text), true, User.AccountType.Professional);

            if (tbPassword.Text == tbPassValidation.Text)
            {
                try
                {
                    UserLogic.AddNewUser(newProfessional, tbPassword.Text);
                    MessageBox.Show("Professional toegevoegd");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("mislukt" + exception);
                }
            }

        }

        private void FormAdminAddProfessional_Load(object sender, EventArgs e)
        {
            foreach (string gender in Enum.GetNames(typeof(User.Gender)))
            {
                cboxSex.Items.Add(gender);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminHome());
        }
    }
}
