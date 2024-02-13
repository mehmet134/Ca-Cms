using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly IApplicationDbContext _context;

        public DoctorRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(DoctorEntity entity)
        {
            _context.Doctors.Add(entity);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task Delete(DoctorEntity entity)
        {
            _context.Doctors.Remove(entity);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<List<DoctorEntity>> GetAll(int page = 1)
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<DoctorEntity> GetById(int id)
        {
            return await _context.Doctors.FindAsync();
        }

        public async Task Update(DoctorEntity entity)
        {
            _context.Doctors.Update(entity);
            await _context.SaveChangesAsync();
            return;
        }
    }
}
