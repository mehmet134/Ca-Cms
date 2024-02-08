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
    public class DoctorEntity : BaseEntity
    {

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string? Phone { get; set; }

        public List<AppointmentEntity>? Appointments { get; set; }

        public List<DoctorCommentEntity>? DoctorComments { get; set; }

        public string? Address { get; set; } = string.Empty;
        public string? ResimDosyaAdi { get; set; }

        public string? ResimYolu
        {
            get
            {
                if (!string.IsNullOrEmpty(ResimDosyaAdi))
                {
                    return "/images/" + ResimDosyaAdi;
                }
                return null;
            }
        }
        public string? Cv { get; set; } = string.Empty;


        public int? NavbarId { get; set; }


        public NavbarEntity? Navbar { get; set; }

        public string? Cat { get; set; }
    }
}
