using System.ComponentModel.DataAnnotations.Schema;

namespace APIListaDeTarefas.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {
        /*● Id (int)
            ● Descricao (string)
            ● DataCriacao (DateTime)
            ● Responsavel (string)
            ● Concluida (bool)
         */
        [Column("id")]
        public int Id { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("dataCriacao")]
        public DateTime DataCriacao { get; set; }

        [Column("responsavel")]
        public string Responsavel { get; set; }
        [Column("concluida")]
        public bool Concluida { get; set; }

    }
}
