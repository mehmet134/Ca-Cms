using Ca.Cms.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Entities
{
    public class BlogCategoryEntity : BaseEntity
    {
        public string Title { get; set; }

        public List<BlogEntity> Blogs { get; set; }
    }
}
