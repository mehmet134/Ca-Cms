using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Entities
{
    public class AppointmentEntity : BaseEntity
    {
        public DepartmentsEnum CategoryId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }

        public DoctorEntity? Doctor { get; set; }

        public PatientEntity? Patient { get; set; }
    }
}
