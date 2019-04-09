using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Logic;
using Fontys.PTS2.Prototype.Model;

namespace Fontys.PTS2.Prototype.View.Volunteer
{
    public partial class FormVolAppointment : Form
    {
        private int _careRecipientID;
        private int _volunteerID;
        private int _questionID;

        public FormVolAppointment(int questionID, int careRecipientID, int volunteerID, string careRecipientName)
        {
            InitializeComponent();

            _questionID = questionID;
            _careRecipientID = careRecipientID;
            _volunteerID = volunteerID;

            tbCareRecipientName.Text = careRecipientName;
        }

        private void btMakeAppointment_Click(object sender, EventArgs e)
        {

            DateTime appointmentDateTime = dtpAppointment.Value;

            Appointment appointment = new Appointment(_questionID, _careRecipientID, _volunteerID, appointmentDateTime);

            AppointmentLogic AL = new AppointmentLogic();
            AL.CreateAppointment(appointment);

            MessageBox.Show("Afspraak gemaakt.");
            ((FormMain)this.Parent.Parent).ReplaceForm(new FormVolChatOverview());

        }
    }
}
