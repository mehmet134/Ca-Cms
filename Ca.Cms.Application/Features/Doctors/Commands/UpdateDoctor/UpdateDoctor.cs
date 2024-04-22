using AutoMapper;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Enums;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Doctors.Commands.UpdateDoctor
{
    public class UpdateDoctorCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DepartmentsEnum CategoryId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }
    }

    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand, bool>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public UpdateDoctorCommandHandler(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<DoctorEntity>(request);
            bool isSuccess = await _repository.Update(entity);
            return isSuccess;
        }
    }
}
