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
    public class DepartmentEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string? ResimDosyaAdi { get; set; }

        public string? ResimYolu
        {
            get
            {
                if (!string.IsNullOrEmpty(ResimDosyaAdi))
                {
                    return "/images/" + ResimDosyaAdi; // wwwroot klasöründeki images altındaki dosyaya göre yol belirtilir.
                }
                return null;
            }
        }

        public int? NavbarId { get; set; }


       // public NavbarEntity? Navbar { get; set; }
    }
}
