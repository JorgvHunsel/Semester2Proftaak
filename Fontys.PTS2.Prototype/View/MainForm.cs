using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontys.PTS2.Prototype.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ReplaceForm(new LoginPrototype());
        }

        public void ReplaceForm(Form newForm)
        {
            for (int i = 0; i < ContainerPanel.Controls.Count; i++)
            {
                ContainerPanel.Controls[0].Dispose();
            }

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;

            ContainerPanel.Size = newForm.Size;
            this.Size = ContainerPanel.Size + new Size(100, 100);

            ContainerPanel.Controls.Add(newForm);
            newForm.Show();
        }
    }
}
