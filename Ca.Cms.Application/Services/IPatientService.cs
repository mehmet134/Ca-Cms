using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Common.Services
{
    public interface IPatientService
    {
        Task<List<PatientEntity>> GetAllPatients();
        Task<PatientEntity> GetPatientById(int id);
        Task CreatePatient(PatientEntity patient);
        Task UpdatePatient(PatientEntity patient);
        Task DeletePatient(PatientEntity patient);
    }
}
