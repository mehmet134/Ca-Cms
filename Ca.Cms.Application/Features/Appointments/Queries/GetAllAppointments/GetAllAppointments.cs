using AutoMapper;
using Ca.Cms.Application.Features.Doctors.Queries;
using Ca.Cms.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Appointments.Queries.GetAllAppointments
{
    public record GetAllAppointmentsQuery : IRequest<ICollection<AppointmentDto>>;
    public class GetAllAppointmentsQueryHandler : IRequestHandler<GetAllAppointmentsQuery, ICollection<AppointmentDto>>
    {
        private readonly IAppointmentRepository _repository;
        private readonly IMapper _mapper;

        public GetAllAppointmentsQueryHandler(IAppointmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<AppointmentDto>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAll().ToListAsync();
            return _mapper.Map<List<AppointmentDto>>(entities);
        }
    }
}
