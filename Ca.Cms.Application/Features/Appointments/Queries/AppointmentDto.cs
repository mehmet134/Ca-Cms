using Ca.Cms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Appointments.Queries
{
    public class AppointmentDto
    {
        public DepartmentsEnum CategoryId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
