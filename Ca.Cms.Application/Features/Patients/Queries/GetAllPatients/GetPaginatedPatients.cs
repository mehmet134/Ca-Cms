using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ca.Cms.Application.Common.Models;
using Ca.Cms.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Patients.Queries.GetAllPatients
{
    public class GetPaginatedPatientsQuery : IRequest<PaginatedResult<PatientDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class GetPaginatedDocumentTypesQueryHandler : IRequestHandler<GetPaginatedPatientsQuery, PaginatedResult<PatientDto>>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public GetPaginatedDocumentTypesQueryHandler(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PaginatedResult<PatientDto>> Handle(GetPaginatedPatientsQuery request, CancellationToken cancellationToken)
        {
            var entities = _repository.GetAll()
                 .OrderByDescending(e => e.Id)
                 .ProjectTo<PatientDto>(_mapper.ConfigurationProvider);

            return await PaginatedResult<PatientDto>.Create(entities.AsNoTracking(), request.PageNumber, request.PageSize);
        }
    }
}
