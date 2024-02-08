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
    public class PatientEntity : BaseEntity
    {
        public string Name { get; set; } 

        public string Surname { get; set; } 

        public string Email { get; set; } 

        public string Password { get; set; } 

        public string? Phone { get; set; }

        //public ICollection<AppointmentEntity> Appointments { get; set; }

        public string? Address { get; set; }
        //public string ResimDosyaAdi { get; set; } // Resim dosya adını burada saklayabilirsiniz.

        //public string ResimYolu
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(ResimDosyaAdi))
        //        {
        //            return "/images/" + ResimDosyaAdi; // wwwroot klasöründeki images altındaki dosyaya göre yol belirtilir.
        //        }
        //        return null;
        //    }
        //}

        public List<PatientCommentEntity>? PatientComments { get; set; }
    }
}
