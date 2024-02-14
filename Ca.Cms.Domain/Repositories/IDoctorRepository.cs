using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Repositories
{
    public interface IDoctorRepository : IRepository<DoctorEntity,int>
    {
    }
}
