using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Common.Services
{
    public class PatientService : IPatientService
    {
        private readonly IApplicationDbContext _context;

        public PatientService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(PatientEntity patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task Delete(PatientEntity patient)
        {
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return;
        }

        public async Task<List<PatientEntity>> GetAll()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<PatientEntity> GetById(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task Update(PatientEntity patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
            return;
        }
    }
}
