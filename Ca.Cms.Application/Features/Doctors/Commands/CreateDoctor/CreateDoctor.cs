using AutoMapper;
using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Enums;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ca.Cms.Application.Features.Doctors.Commands.CreateDoctor
{
    public class CreateDoctorCommand : IRequest<int>
    {
        public DepartmentsEnum CategoryId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

    }

    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, int>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public CreateDoctorCommandHandler(IDoctorRepository customerRepository, IMapper mapper)
        {
            _repository = customerRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<DoctorEntity>(request);
            var id = await _repository.Create(entity);
            return id;
        }
    }
}
