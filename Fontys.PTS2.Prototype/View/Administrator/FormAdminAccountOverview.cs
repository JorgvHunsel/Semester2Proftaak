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
    public partial class FormAdminAccountOverview : Form
    {
        public FormAdminAccountOverview()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormAdminHome());
        }

        void LoadListview()
        {
            lvUserOverview.Items.Clear();
            foreach (User user in UserLogic.GetAllUsers())
            {
                ListViewItem item = new ListViewItem(user.UserId.ToString());

                item.SubItems.Add(user.UserAccountType.ToString());
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.BirthDate.ToString());
                item.SubItems.Add(user.UserGender.ToString());
                item.SubItems.Add(user.EmailAddress);
                item.SubItems.Add(user.Address);
                item.SubItems.Add(user.PostalCode);
                item.SubItems.Add(user.City);
                item.SubItems.Add(user.Status.ToString());

                lvUserOverview.Items.Add(item);
            }
        }

        private void AccountOverviewAdminForm_Load(object sender, EventArgs e)
        {
           LoadListview();
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            try
            {
                User selectedUser =
                    UserLogic.getCurrentUserInfo(lvUserOverview.Items[lvUserOverview.SelectedItems[0].Index].SubItems[6]
                        .Text);

                if (selectedUser.Status)
                    selectedUser.Status = false;
                else
                {
                    selectedUser.Status = true;
                }

                UserLogic.EditUser(selectedUser, "");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Selecteer een gebruiker");
                throw;
            }
            finally
            {
                LoadListview();
            }
        }
    }
}

