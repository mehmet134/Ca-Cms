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

namespace Ca.Cms.Application.Features.Appointments.Commands.UpdateAppointment
{
    public class UpdateAppointmentCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DepartmentsEnum CategoryId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }

    }

    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateAppointmentCommand, bool>
    {
        private readonly IAppointmentRepository _repository;
        private readonly IMapper _mapper;

        public UpdateDoctorCommandHandler(IAppointmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<AppointmentEntity>(request);
            bool isSuccess = await _repository.Update(entity);
            return isSuccess;
        }
    }
}
