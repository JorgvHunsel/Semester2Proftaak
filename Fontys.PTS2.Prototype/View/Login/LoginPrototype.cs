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

namespace Fontys.PTS2.Prototype.View
{

    public partial class LoginPrototype : Form
    {
        public static int CurrentUserId { get; set; }
        
        private List<string> userNames;
        
        public LoginPrototype()
        {
            InitializeComponent();
        }

        private void LoginPrototype_Load(object sender, EventArgs e)
        {
            userNames = UserContextSQL.GetAllUsers();
            foreach (string FirstName in userNames)
            {
                //cboxUsers.Items.Add(FirstName);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* try
            {
                //string selectedUser = cboxUsers.SelectedItem.ToString();
                CurrentUserId = QueryUsers.GetUserId(selectedUser);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is geen gebruiker ingevoerd");
                return;
            }
            
           if (rbtnCareRecipient.Checked)
            {
                ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
            }
            else if (rbtnVolunteer.Checked)
            {
                ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverview());
            }
            else
            {
                MessageBox.Show("Kies een rol");
            }*/
        }
    }
}
