using AutoMapper;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ca.Cms.Application.Features.Patients.Commands.CreatePatient
{
    public class CreatePatientCommand : IRequest<int>
    {
        public string? Name { get; set; }
                     
        public string? Surname { get; set; }
                     
        public string? Email { get; set; }
                     
        public string? Password { get; set; }

        public long? Phone { get; set; }

    }

    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public CreatePatientCommandHandler(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PatientEntity>(request);
            var id = await _repository.Create(entity);
            return id;
        }
    }
}
