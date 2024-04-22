using AutoMapper;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Doctors.Commands.DeleteDoctor
{
    public record DeleteDoctorCommand(int Id) : IRequest<bool>;

    public class DeleteDoctorCommandHandler : IRequestHandler<DeleteDoctorCommand, bool>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public DeleteDoctorCommandHandler(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteDoctorCommand request, CancellationToken cancellationToken)
        {
            bool isSuccess = await _repository.DeleteById(request.Id);
            return isSuccess;
        }
    }
}
