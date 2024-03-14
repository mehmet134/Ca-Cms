using AutoMapper;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Doctors.Queries.GetDoctorById
{
    public class GetDoctorByIdQuery : IRequest<DoctorDto>
    {
        public int Id { get; set; }

        public GetDoctorByIdQuery(int id)
        {
            Id = id;
        }
    }
    public class GetDoctorByIdQueryHandler : IRequestHandler<GetDoctorByIdQuery, DoctorDto?>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public GetDoctorByIdQueryHandler(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<DoctorDto?> Handle(GetDoctorByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetById(request.Id);
            return _mapper.Map<DoctorDto>(entity);
        }
    }
}
