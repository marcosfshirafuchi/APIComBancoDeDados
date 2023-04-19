using APIListaDeTarefas.Models;
using System.Runtime.Intrinsics.X86;

namespace APIListaDeTarefas.Repository.Interfaces
{
    public interface ITarefaRepository
    {
        /*
            ● Consultar todas as tarefas
            ● Consultar todas as tarefas concluídas
            ● Consultar todas as tarefas em aberto
            ● Incluir uma nova tarefa
            ● Atualizar a descrição de uma tarefa
            ● Excluir uma tarefa
         */

        List<Tarefa> ConsultarTodasAsTarefas();
        List<Tarefa> ConsultarTodasAsTarefasConcluidas();
        List<Tarefa> ConsultarTodasAsTarefasEmAberto();
        int IncluirUmaNovaTarefa(Tarefa tarefa);
        Tarefa? AtualizarADescriçãoDeUmaTarefa(Tarefa tarefa);
        public void ExcluirUmaTarefa(int idTarefa);
    }
}
