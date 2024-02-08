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
    public class PatientCommentEntity : BaseEntity
    {
        public int PatientId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public PatientEntity? Patient { get; set; }
    }
}
