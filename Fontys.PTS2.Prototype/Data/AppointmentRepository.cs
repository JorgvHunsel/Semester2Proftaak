using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fontys.PTS2.Prototype.Data.Contexts;
using Fontys.PTS2.Prototype.Model;

namespace Fontys.PTS2.Prototype.Data
{
    public class AppointmentRepository
    {
        
        
        private IAppointmentContext context;

        public AppointmentRepository()
        {
            this.context = new AppointmentContextSQL();
        }

        public AppointmentRepository(IAppointmentContext context)
        {
            this.context = context;
        }

        public void CreateAppointment(Appointment appointment) => context.CreateAppointment(appointment);


    }
}
