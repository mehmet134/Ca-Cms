using Ca.Cms.Domain.Common;
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
        public int? DoctorCategoryId { get; set; }
        public int? DoctorId { get; set; }
        public int? PatientId { get; set; }
        public DateTime DateTime { get; set; }
        //enum


        public DoctorEntity? Doctor { get; set; }

        public PatientEntity? Patient { get; set; }
    }
}
