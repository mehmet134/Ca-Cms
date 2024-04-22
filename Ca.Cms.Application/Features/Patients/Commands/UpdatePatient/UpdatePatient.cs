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

namespace Ca.Cms.Application.Features.Patients.Commands.UpdatePatient
{
    public class UpdatePatientCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public long? Phone { get; set; }
    }
    public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommand, bool>
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public UpdatePatientCommandHandler(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PatientEntity>(request);
            bool isSuccess = await _repository.Update(entity);
            return isSuccess;
        }
    }
}
