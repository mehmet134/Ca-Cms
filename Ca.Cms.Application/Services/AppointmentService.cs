using AutoMapper;
using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Application.Dtos;
using Ca.Cms.Application.Services.Interfaces;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ca.Cms.Application.Services
{
    public class AppointmentService :IAppointmentService
    {
        private readonly IApplicationDbContext _db;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentService(IApplicationDbContext db, IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _db = db;
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }
        public async Task<List<AppointmentDto>> GetAll()
        {
            var entity = await _appointmentRepository.GetAll();
            return _mapper.Map<List<AppointmentDto>>(entity).ToList();

        }
        public async Task Create(CreateOrEditAppointmentDto dto)
        {
            var entity = _mapper.Map<AppointmentEntity>(dto);
            return _appointmentRepository.Create(dto);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

       
      
        public async Task<AppointmentDto?> GetById(int id)
        {
            var entity = await _appointmentRepository.GetById(id);
            return _mapper.Map<AppointmentDto>(entity);

            
        }

        public Task<CreateOrEditAppointmentDto?> GetFormById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CreateOrEditAppointmentDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
