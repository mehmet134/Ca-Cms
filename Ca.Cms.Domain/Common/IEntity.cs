using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Common
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
