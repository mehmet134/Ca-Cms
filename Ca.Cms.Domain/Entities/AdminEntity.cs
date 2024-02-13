using Ca.Cms.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Entities
{
    public class AdminEntity : BaseEntity
    {
        public string Name { get; set; } 

        public string Surname { get; set; } 

        public string Email { get; set; } 

        public string Password { get; set; } 

        public string Phone { get; set; } 


        public string Address { get; set; } 
       
        public string? Cv { get; set; } 
    }
}
