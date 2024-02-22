using Ca.Cms.Application.Dtos;
using Ca.Cms.Application.Services.Interfaces;
using Ca.Cms.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entity = await _service.GetAll();
            return Ok(entity);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity =  await _service.GetById(id);
            return Ok(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateOrEditContactDto dto)
        {
            await _service.Create(dto);

            return Ok(dto);
        }




    }
}
