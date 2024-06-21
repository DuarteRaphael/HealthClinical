using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinical.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            return Ok();
        }
        [HttpGet("{page}/{limit}")]
        public IActionResult GetAll(Guid id)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
    }
}
