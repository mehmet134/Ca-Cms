using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
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
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public async Task CreatePatient(PatientEntity patient)
        {
             await _repository.Create(patient);
        }

        public async Task DeletePatient(PatientEntity patient)
        {
           await _repository.Delete(patient);
        }

        public async Task<List<PatientEntity>> GetAllPatients()
        {
           return await _repository.GetAll();
        }

        public async Task<PatientEntity> GetPatientById(int id)
        {
           return await _repository.GetById(id);
        }

        public async Task UpdatePatient(PatientEntity patient)
        {
            await _repository.Update(patient);
        }
    }
}
