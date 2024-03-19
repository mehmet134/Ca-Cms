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

namespace Ca.Cms.Application.Features.Appointments.Commands.CreateAppointment
{
    public class CreateAppointmentCommand : IRequest<int>
    {
        public DepartmentsEnum CategoryId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }

    }

    public class CreateDoctorCommandHandler : IRequestHandler<CreateAppointmentCommand, int>
    {
        private readonly IAppointmentRepository _repository;
        private readonly IMapper _mapper;

        public CreateDoctorCommandHandler(IAppointmentRepository customerRepository, IMapper mapper)
        {
            _repository = customerRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<AppointmentEntity>(request);
            var id = await _repository.Create(entity);
            return id;
        }
    }
}
