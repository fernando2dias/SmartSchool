using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: blablabla....");
        }
    }
}