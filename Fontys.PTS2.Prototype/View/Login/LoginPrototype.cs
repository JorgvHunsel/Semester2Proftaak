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
using Fontys.PTS2.Prototype.View.Login;

namespace Fontys.PTS2.Prototype.View
{

    public partial class LoginPrototype : Form
    {

        private List<string> userNames;
        public static User currentUser;

        public LoginPrototype()
        {
            InitializeComponent();
        }

        private void LoginPrototype_Load(object sender, EventArgs e)
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
                        ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
                    else if (currentUser.UserAccountType == User.AccountType.Volunteer)
                        ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewVolunteer());
                }
                else
                {
                    ((MainForm)this.Parent.Parent).ReplaceForm(new LoginPrototype());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is geen gebruiker ingevoerd");
                return;
            }
        }

        private void linklblNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new NewUser());
        }
    }
}
