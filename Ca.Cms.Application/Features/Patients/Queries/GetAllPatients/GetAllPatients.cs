using AutoMapper;
using Ca.Cms.Application.Dtos;
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
    public record GetAllPatientsQuery : IRequest<ICollection<PatientDto>>;

    public class GetAllPatientsQueryHandler : IRequestHandler<GetAllPatientsQuery, ICollection<PatientDto>>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public GetAllPatientsQueryHandler(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<PatientDto>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAll().ToListAsync();
            return _mapper.Map<List<PatientDto>>(entities);
        }
    }
}
