using Ca.Cms.Application.Dtos;
using Ca.Cms.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Services.Interfaces
{
    public interface  IContactService 
    {
        Task<List<ContactDto>> GetAll();

        Task<ContactDto?> GetById(int id);

        //Task<CreateOrEditAppointmentDto?> GetFormById(int id);

        Task<int> Create(CreateOrEditContactDto customer);

        Task<bool> Update(CreateOrEditContactDto customer);

        Task<bool> Delete(int id);
    }
}
