using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Ca.Cms.Infrastructure.Persistence.Common;
using Ca.Cms.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Repositories
{
    public class BlogCategoryRepository : BaseRepository<BlogCategoryEntity, int>, IBlogCategoryRepository
    {
        public BlogCategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
