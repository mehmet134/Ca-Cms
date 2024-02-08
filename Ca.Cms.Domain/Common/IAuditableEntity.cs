using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Common
{
    public interface IAuditableEntity
    {
        DateTimeOffset CreatedAt { get; set; }

        string? CreatedBy { get; set; }

        DateTimeOffset? LastModifiedAt { get; set; }

        string? LastModifiedBy { get; set; }

        DateTimeOffset? DeletedAt { get; set; }

        string? DeletedBy { get; set; }
    }
}
