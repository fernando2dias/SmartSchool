using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        public AlunoController()
        {

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Alunos: blablabla....");
        }

    }
}