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
        Task<List<PatientEntity>> GetAll();
        Task<PatientEntity> GetById(int id);
        Task Create(PatientEntity patient);
        Task Update(PatientEntity patient);
        Task Delete(PatientEntity patient);
    }
}
