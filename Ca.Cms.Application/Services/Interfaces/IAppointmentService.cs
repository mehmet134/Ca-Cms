using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ca.Cms.Application.Dtos;

namespace Ca.Cms.Application.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDto>> GetAll();

        Task<AppointmentDto?> GetById(int id);

        //Task<CreateOrEditAppointmentDto?> GetFormById(int id);

        Task<int> Create(CreateOrEditAppointmentDto customer);

        Task<bool> Update(CreateOrEditAppointmentDto customer);

        Task<bool> Delete(int id);
    }
}
