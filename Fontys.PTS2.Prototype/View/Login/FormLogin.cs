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
using Fontys.PTS2.Prototype.View.Administrator;
using Fontys.PTS2.Prototype.View.CareRecipient;
using Fontys.PTS2.Prototype.View.Login;
using Fontys.PTS2.Prototype.View.Volunteer;

namespace Fontys.PTS2.Prototype.View
{

    public partial class FormLogin : Form
    {

        private List<string> userNames;
        public static User currentUser;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedUser = tboxEmail.Text;
                string password = tbPassword.Text;
                if (UserLogic.CheckValidityUser(selectedUser, password))
                {
                    currentUser = UserLogic.getCurrentUserInfo(selectedUser);
                    if (currentUser.UserAccountType == User.AccountType.CareRecipient)
                        ((FormMain)this.Parent.Parent).ReplaceForm(new FormCareHome());
                    else if (currentUser.UserAccountType == User.AccountType.Volunteer)
                        ((FormMain)this.Parent.Parent).ReplaceForm(new FormVolHome());
                    else if (currentUser.UserAccountType == User.AccountType.Admin)
                    {
                        ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminHome());
                    }
                }
                else
                {
                    ((FormMain)this.Parent.Parent).ReplaceForm(new FormLogin());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is geen gebruiker ingevoerd");
                throw;
            }
        }

        private void linklblNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormCreateAccount());
        }
    }
}
