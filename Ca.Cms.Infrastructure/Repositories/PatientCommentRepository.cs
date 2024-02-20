using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Ca.Cms.Infrastructure.Persistence;
using Ca.Cms.Infrastructure.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Repositories
{
    public class PatientCommentRepository : BaseRepository<PatientCommentEntity, int> , IPatientCommentRepository
    {
        public PatientCommentRepository(ApplicationDbContext context) : base(context) { }
       
    }
}
