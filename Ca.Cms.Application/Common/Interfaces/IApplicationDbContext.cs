using Ca.Cms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<AdminEntity> Admins { get;  }
        DbSet<AppointmentEntity> Appointments { get;  }
        DbSet<BlogCategoryEntity> BlogCategories { get;  }
        DbSet<BlogEntity> Blogs { get;  }
        DbSet<CommentEntity> Comments { get;  }
        DbSet<ContactEntity> Contacts { get;  }
        DbSet<DepartmentEntity> Departments { get;  }
        DbSet<DoctorEntity> Doctors { get;  }
        DbSet<NavbarEntity> Navbars { get;  }
        DbSet<PatientEntity> Patients { get;  }
        DbSet<PatientCommentEntity> PatientComments { get;  }
        DbSet<ServiceBlogEntity> ServiceBlogs { get;  }
        Task SaveChangesAsync();












    }
}
