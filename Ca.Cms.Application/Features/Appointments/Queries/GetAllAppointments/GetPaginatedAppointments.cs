using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ca.Cms.Application.Common.Models;
using Ca.Cms.Application.Features.Doctors.Queries;
using Ca.Cms.Application.Features.Patients.Queries;
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
    public class GetPaginatedAppointmentsQuery : IRequest<PaginatedResult<AppointmentDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class GetPaginatedAppointmentQueryHandler : IRequestHandler<GetPaginatedAppointmentsQuery, PaginatedResult<AppointmentDto>>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public GetPaginatedAppointmentQueryHandler(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PaginatedResult<AppointmentDto>> Handle(GetPaginatedAppointmentsQuery request, CancellationToken cancellationToken)
        {
            var entities = _repository.GetAll()
                .Include(e => e.PatientComments)
                 .OrderByDescending(e => e.Id)
                 .ProjectTo<AppointmentDto>(_mapper.ConfigurationProvider);

            return await PaginatedResult<AppointmentDto>.Create(entities.AsNoTracking(), request.PageNumber, request.PageSize);
        }
    }
}
