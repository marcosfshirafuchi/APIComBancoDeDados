using APIListaDeTarefas.Data;
using APIListaDeTarefas.Repository;
using APIListaDeTarefas.Repository.Interfaces;

namespace APIListaDeTarefas
{
    /*rabalho em grupo do curso C# do RDI sobre API com Banco de dados na linguagem C#(Csharp):
     Marcos Ferreira Shirafuchi
     Marcos Suda
     José Alexandre
     Giovanna Ney
     Felipe Estevão
     Lucas Iozzi
     Kelly Costa
     
    Criando uma api para lista de tarefas
    Crie uma API para o gerenciamento de uma lista de tarefas pessoal, como por exemplo:
    - Estudar para prova de programação
    - Estudar para a prova de matemática
    - Ligar para meu amigo e perguntar quando devo entregar o trabalho
    É uma lista de afazeres.

    As tarefas serão representadas por uma classe chamada Tarefa e deve possuir os seguintes atributos:
    - Id (int)
    - Descricao (string)
    - DataCriacao (DateTime)
    - Responsavel (string)
    - Concluida (bool)

    Deverá ser criada uma classe Controller, para que a api receba as requisições de manipulação das tarefas. A controller deverá possuir métodos para:
    - Consultar todas as tarefas
    - Consultar todas as tarefas concluídas
    - Consultar todas as tarefas em aberto
    - Incluir uma nova tarefa
    - Atualizar a descrição de uma tarefa
    - Excluir uma tarefa

    Atenção:
    - Todas as tarefas deverão ser armazenadas em um banco de dados SQlite.
    Consequentemente, todas as manipulações das tarefas serão feitas com o banco;
    - Coloque DataAnnotation na classe Model, para representar de maneira correta o nome da tabela e suas colunas no banco de dados;
    - Separe os métodos de manipulação do banco de dados em classes do sufixo “Repository”;
    - Teste todos os métodos no Postman;
    - A utilização do Swagger é opcional
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Adicionando novo serviço de contexto de conexão ao banco de dados
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