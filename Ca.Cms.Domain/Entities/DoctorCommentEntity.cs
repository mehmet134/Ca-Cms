using Ca.Cms.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Entities
{
    public class DoctorCommentEntity : BaseEntity
    {
        public string Title { get; set; }

        public int DoctorId { get; set; }
        public string Description { get; set; }
        public DoctorEntity? Doctor { get; set; }
    }
}
