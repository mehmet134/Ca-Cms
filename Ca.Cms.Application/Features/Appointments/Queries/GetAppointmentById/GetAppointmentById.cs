using AutoMapper;
using Ca.Cms.Application.Features.Doctors.Queries;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Appointments.Queries.GetAppointmentById
{
    public class GetAppointmentByIdQuery : IRequest<AppointmentDto>
    {
        public int Id { get; set; }

        public GetAppointmentByIdQuery(int id)
        {
            Id = id;
        }
    }
    public class GetAppointmentByIdQueryHandler : IRequestHandler<GetAppointmentByIdQuery, AppointmentDto?>
    {
        private readonly IAppointmentRepository _repository;
        private readonly IMapper _mapper;

        public GetAppointmentByIdQueryHandler(IAppointmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AppointmentDto?> Handle(GetAppointmentByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetById(request.Id);
            return _mapper.Map<AppointmentDto>(entity);
        }
    }
}
