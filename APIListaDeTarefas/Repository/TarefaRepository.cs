using APIListaDeTarefas.Data;
using APIListaDeTarefas.Models;
using APIListaDeTarefas.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace APIListaDeTarefas.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Tarefa ConsultarTarefaPorId(int id) 
        {
            return _context.Tarefas.Find(id);
        
        }
        public List<Tarefa> ConsultarTodasAsTarefas()
        {
            return _context.Tarefas.ToList();
        }

        public List<Tarefa> ConsultarTodasAsTarefasConcluidas()
        {
            return _context.Tarefas.FromSqlRaw("select * from Tarefa WHERE concluida = TRUE").ToList();
        }

        public List<Tarefa> ConsultarTodasAsTarefasEmAberto()
        {
            return _context.Tarefas.FromSqlRaw("select * from Tarefa WHERE concluida = FALSE").ToList();
        }

        public int IncluirUmaNovaTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return tarefa.Id;
        }
        public Tarefa? AtualizarADescriçãoDeUmaTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
            return tarefa;
        }

        public void ExcluirUmaTarefa(int idTarefa)
        {
            var tarefa = ConsultarTarefaPorId(idTarefa);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                _context.SaveChanges();
            }
        }
    }
}
