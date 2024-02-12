using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Common
{
    public class BaseAuditableEntity<TKey> : BaseEntity<TKey> , IAuditableEntity
    {
        public DateTimeOffset CreatedAt { get; set; }

        public string? CreatedBy { get; set; }

        public DateTimeOffset? LastModifiedAt { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }

        public string? DeletedBy { get; set; }
    }
    public abstract class BaseAuditableEntity : BaseAuditableEntity<int>
    {
    }
}
