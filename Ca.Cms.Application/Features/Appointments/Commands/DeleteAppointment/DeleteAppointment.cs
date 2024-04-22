using AutoMapper;
using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Appointments.Commands.DeleteAppointment
{
    public record DeleteAppointmentCommand(int Id) : IRequest<bool>;

    public class DeleteAppointmentCommandHandler : IRequestHandler<DeleteAppointmentCommand, bool>
    {
        private readonly IAppointmentRepository _repository;
        private readonly IMapper _mapper;

        public DeleteAppointmentCommandHandler(IAppointmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
        {
            bool isSuccess = await _repository.DeleteById(request.Id);
            return isSuccess;
        }
    }
}
