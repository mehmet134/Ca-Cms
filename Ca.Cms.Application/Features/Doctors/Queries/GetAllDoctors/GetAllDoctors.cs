using AutoMapper;
using Ca.Cms.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Doctors.Queries.GetAllDoctors
{
    public record GetAllDoctorsQuery : IRequest<ICollection<DoctorDto>>;
    public class GetAllDoctorsQueryHandler : IRequestHandler<GetAllDoctorsQuery, ICollection<DoctorDto>>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public GetAllDoctorsQueryHandler(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<DoctorDto>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAll().ToListAsync();
            return _mapper.Map<List<DoctorDto>>(entities);
        }
    }

}
