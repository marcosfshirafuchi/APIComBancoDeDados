using APIListaDeTarefas.Data;
using APIListaDeTarefas.Repository;
using APIListaDeTarefas.Repository.Interfaces;

namespace APIListaDeTarefas
{
    /*rabalho em grupo do curso C# do RDI sobre API com Banco de dados na linguagem C#(Csharp):
     Marcos Ferreira Shirafuchi
     Marcos Suda
     Jos� Alexandre
     Giovanna Ney
     Felipe Estev�o
     Lucas Iozzi
     Kelly Costa
     
    Criando uma api para lista de tarefas
    Crie uma API para o gerenciamento de uma lista de tarefas pessoal, como por exemplo:
    - Estudar para prova de programa��o
    - Estudar para a prova de matem�tica
    - Ligar para meu amigo e perguntar quando devo entregar o trabalho
    � uma lista de afazeres.

    As tarefas ser�o representadas por uma classe chamada Tarefa e deve possuir os seguintes atributos:
    - Id (int)
    - Descricao (string)
    - DataCriacao (DateTime)
    - Responsavel (string)
    - Concluida (bool)

    Dever� ser criada uma classe Controller, para que a api receba as requisi��es de manipula��o das tarefas. A controller dever� possuir m�todos para:
    - Consultar todas as tarefas
    - Consultar todas as tarefas conclu�das
    - Consultar todas as tarefas em aberto
    - Incluir uma nova tarefa
    - Atualizar a descri��o de uma tarefa
    - Excluir uma tarefa

    Aten��o:
    - Todas as tarefas dever�o ser armazenadas em um banco de dados SQlite.
    Consequentemente, todas as manipula��es das tarefas ser�o feitas com o banco;
    - Coloque DataAnnotation na classe Model, para representar de maneira correta o nome da tabela e suas colunas no banco de dados;
    - Separe os m�todos de manipula��o do banco de dados em classes do sufixo �Repository�;
    - Teste todos os m�todos no Postman;
    - A utiliza��o do Swagger � opcional
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Adicionando novo servi�o de contexto de conex�o ao banco de dados
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddTransient<ITarefaRepository, TarefaRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}