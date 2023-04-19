using APIListaDeTarefas.Models;
using APIListaDeTarefas.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIListaDeTarefas.Controllers
{
    [Route("[controller]")]
    public class TarefaController : Controller
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        [HttpGet("[action]")]
        public List<Tarefa> ConsultarTodasAsTarefas() 
        { 
            return _tarefaRepository.ConsultarTodasAsTarefas();
        }


        [HttpGet("[action]")]
        public List<Tarefa> ConsultarTodasAsTarefasEmAberto() 
        {
            return _tarefaRepository.ConsultarTodasAsTarefasEmAberto();
        }

        [HttpGet("[action]")]
        public List<Tarefa> ConsultarTodasAsTarefasConcluidas()
        {
            return _tarefaRepository.ConsultarTodasAsTarefasConcluidas();
        }

        [HttpPost("[action]")]
        public int IncluirUmaNovaTarefa([FromBody] Tarefa tarefa)
        {
            return _tarefaRepository.IncluirUmaNovaTarefa(tarefa);
        }
        [HttpPut("[action]")]
        public Tarefa? AtualizarADescriçãoDeUmaTarefa([FromBody] Tarefa tarefa)
        {
            return _tarefaRepository.AtualizarADescriçãoDeUmaTarefa(tarefa);
        }

        [HttpDelete("[action]/{id}")]
        public void ExcluirUmaTarefa(int id)
        {
             _tarefaRepository.ExcluirUmaTarefa(id);
        }
    }
}
