using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{
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