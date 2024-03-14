using Ca.Cms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Doctors.Queries
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public DepartmentsEnum CategoryId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

    }
}
