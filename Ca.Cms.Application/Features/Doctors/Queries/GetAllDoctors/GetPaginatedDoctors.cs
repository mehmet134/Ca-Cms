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

namespace Ca.Cms.Application.Features.Doctors.Queries.GetAllDoctors
{
    public class GetPaginatedDoctorsQuery : IRequest<PaginatedResult<DoctorDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class GetPaginatedDoctorsQueryHandler : IRequestHandler<GetPaginatedDoctorsQuery, PaginatedResult<DoctorDto>>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public GetPaginatedDoctorsQueryHandler(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PaginatedResult<DoctorDto>> Handle(GetPaginatedDoctorsQuery request, CancellationToken cancellationToken)
        {
            var entities = _repository.GetAll()
                 .OrderByDescending(e => e.Id)
                 .ProjectTo<DoctorDto>(_mapper.ConfigurationProvider);

            return await PaginatedResult<DoctorDto>.Create(entities.AsNoTracking(), request.PageNumber, request.PageSize);
        }
    }

   
}
