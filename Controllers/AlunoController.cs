using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        public AlunoController()
        {

        }


        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Fernando",
                Sobrenome = "Dias",
                Telefone = "121232323"
            },
            new Aluno(){
                Id = 2,
                Nome = "Juliana",
                Sobrenome = "Michelsen",
                Telefone = "564344343"
            },
            new Aluno(){
                Id = 3,
                Nome = "Neco",
                Sobrenome = "Belico",
                Telefone = "979644322"
            },
            new Aluno(){
                Id = 4,
                Nome = "Preta",
                Sobrenome = "Belico",
                Telefone = "32323"
            },
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(al => al.Id == id);

            return (aluno != null) ? Ok(aluno) : BadRequest("Aluno não encontrado");
        }

        //aluno/byName?nome=Fernando&sobrenome=Motta
        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(al => al.Nome.Contains(nome) && al.Sobrenome.Contains(sobrenome));

            return (aluno != null) ? Ok(aluno) : BadRequest("Aluno não encontrado");
        }


        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}