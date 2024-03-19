using Ca.Cms.Application.Features.Patients.Commands.CreatePatient;
using Ca.Cms.Application.Features.Patients.Commands.DeletePatient;
using Ca.Cms.Application.Features.Patients.Commands.UpdatePatient;
using Ca.Cms.Application.Features.Patients.Queries.GetAllPatients;
using Ca.Cms.Application.Features.Patients.Queries.GetPatientById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PatientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetPaginatedPatientsQuery query)
        {
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _mediator.Send(new GetPatientByIdQuery(id));
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreatePatientCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, UpdatePatientCommand command)
        {
            if (id == command.Id)
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            return Ok(false);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeletePatientCommand(id));
            return Ok(response);
        }
    }
}
