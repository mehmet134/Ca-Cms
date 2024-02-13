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
    public class CommentEntity : BaseEntity
    {
        public string Text { get; set; }
        public int PatientId { get; set; }
        public int BlogId { get; set; }
        public BlogEntity? Blog { get; set; }

        public PatientEntity? Patient { get; set; }
    }
}
