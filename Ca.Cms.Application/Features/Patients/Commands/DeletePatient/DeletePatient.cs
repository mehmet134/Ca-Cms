using Ca.Cms.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Patients.Commands.DeletePatient
{
    public record DeletePatientCommand(int Id) : IRequest<bool>;

    public class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommand, bool>
    {
        private readonly IPatientRepository _repository;

        public DeletePatientCommandHandler(IPatientRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            bool isSuccess = await _repository.DeleteById(request.Id);
            return isSuccess;
        }
    }
}
