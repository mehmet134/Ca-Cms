using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Common
{
    public class PaginatedEntities<TEntity>
    {
        public int Count { get; set; }

        public IEnumerable<TEntity> Entities { get; set; }
    }
}
