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

namespace Ca.Cms.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;
        private readonly IApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository repository, IApplicationDbContext db, IMapper mapper)
        {
            _repository = repository;
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<ContactDto>> GetAll()
        {
            var entity = await _repository.GetAll();
            return _mapper.Map<List<ContactDto>>(entity).ToList();

        }
        public async Task<int> Create(CreateOrEditContactDto dto)
        {
            var entity = _mapper.Map<ContactEntity>(dto);
            await _repository.Create(entity);
            return await _db.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
            //bool isSucces = await _appointmentRepository.Deleteb(id);
            //await _db.SaveChangesAsync();
            //return isSucces;
        }



        public async Task<ContactDto?> GetById(int id)
        {
            var entity = await _repository.GetById(id);
            return _mapper.Map<ContactDto>(entity);


        }

        public async Task<bool> Update(CreateOrEditContactDto customer)
        {
            //var entity = _mapper.Map<CreateOrEditAppointmentDto>(customer);
            //await _appointmentRepository.Update(entity);
            //return await _db.SaveChangesAsync();
            throw new NotImplementedException();

        }
    }
}
