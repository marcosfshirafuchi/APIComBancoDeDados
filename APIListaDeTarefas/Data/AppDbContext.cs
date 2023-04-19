using APIListaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace APIListaDeTarefas.Data
{
    public class AppDbContext : DbContext
    {
        //Representação da tabela Tarefa
        public DbSet<Tarefa> Tarefas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}
