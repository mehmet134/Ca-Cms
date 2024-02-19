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
    public class DoctorCommentEntity : BaseEntity
    {
        public int DoctorId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DoctorEntity Doctor { get; set; }
    }
}
