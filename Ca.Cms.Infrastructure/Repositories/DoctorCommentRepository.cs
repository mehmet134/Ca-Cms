﻿using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Ca.Cms.Infrastructure.Persistence;
using Ca.Cms.Infrastructure.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Repositories
{
    public class DoctorCommentRepository : BaseRepository<DoctorCommentEntity, int>, IDoctorCommentRepository

    {
        public DoctorCommentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
