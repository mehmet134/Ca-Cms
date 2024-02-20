using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;

namespace Ca.Cms.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
       public DbSet<AdminEntity> Admins { get; set; }
       public DbSet<AppointmentEntity> Appointments { get; set; }
       public DbSet<BlogCategoryEntity> BlogCategories { get; set; }
       public DbSet<BlogEntity> Blogs { get; set; }
       public DbSet<CommentEntity> Comments { get; set; }
       public DbSet<ContactEntity> Contacts { get; set; }
       public DbSet<DepartmentBlogEntity> DepartmentBlogs { get; set; }
       public DbSet<DoctorEntity> Doctors { get; set; }
       public DbSet<NavbarEntity> Navbars { get; set; }
       public DbSet<PatientEntity> Patients { get; set; }
       public DbSet<PatientCommentEntity> PatientComments { get; set; }
       public DbSet<ServiceBlogEntity> ServiceBlogs { get; set; }
        public DbSet<DoctorCommentEntity> DoctorComments { get; set; }

        private readonly IUser _currentUser;
        private readonly TimeProvider _dateTime;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        

}
