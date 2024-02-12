using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ca.Cms.Domain.Common;

namespace Ca.Cms.Domain.Entities
{
    public class NavbarEntity : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<DoctorEntity> Doctors { get; set; }
        //public ICollection<DepartmentEntity> Departments { get; set; }
    }
}
