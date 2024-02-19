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
    public class ContactEntity : BaseEntity
    {
        public string Fullname { get; set; } 
        public string Topic { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public string Text { get; set; }
    }
}
