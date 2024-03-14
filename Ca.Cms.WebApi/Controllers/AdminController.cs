using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    ////[Route("api/[controller]")]
    ////[ApiController]
    ////public class AdminController : ControllerBase
    ////{
    ////    private readonly IAdminRepository _repository;

    ////    public AdminController(IAdminRepository repository)
    ////    {
    ////        _repository = repository;
    ////    }

    ////    [HttpGet]
    ////    public async Task<IActionResult> Get()
    ////    {
    ////       var admins =  await _repository.GetAll();
    ////        return Ok(admins);
            
    ////    }
    ////    [HttpGet("{id}")]
    ////    public async Task<IActionResult> GeyByIdAdmin(int id)
    ////    {
    ////        var admin = await _repository.GetById(id);
    ////        return Ok(admin);
    ////    }
    ////}
}
