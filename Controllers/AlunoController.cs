using Microsoft.AspNetCore.Mvc;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly SmartSchoolContext _context;

        public AlunoController(SmartSchoolContext context)
        {
            _context = context;
        }



        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(al => al.Id == id);

            return (aluno != null) ? Ok(aluno) : BadRequest("Aluno não encontrado");
        }

        //aluno/byName?nome=Fernando&sobrenome=Motta
        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = _context.Alunos.FirstOrDefault(al => al.Nome.Contains(nome) && al.Sobrenome.Contains(sobrenome));

            return (aluno != null) ? Ok(aluno) : BadRequest("Aluno não encontrado");
        }


        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = GetById(id);
            _context.Remove(aluno);
            _context.SaveChanges();
            return Ok();
        }

    }
}