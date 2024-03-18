using AutoMapper;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Patients.Queries.GetPatientById
{
    public class GetPatientByIdQuery : IRequest<PatientDto>
    {
        public int Id { get; set; }

        public GetPatientByIdQuery(int id)
        {
            Id = id;
        }
    }
    public class GetDocmuentTypeByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, PatientDto?>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public GetDocmuentTypeByIdQueryHandler(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PatientDto?> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetById(request.Id);
            return _mapper.Map<PatientDto>(entity);
        }
    }
}
