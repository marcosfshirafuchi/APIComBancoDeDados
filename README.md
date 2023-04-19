# APIComBancoDeDados<br>
Trabalho em grupo do curso C# do RDI sobre API com Banco de dados na linguagem C#(Csharp): <br>  
- Felipe Estevão.  <br>
- Giovanna Ney.  <br>
- José Alexandre.  <br>
- Lucas Iozzi.  <br>
- Kelly Costa. <br> 
- Marcos Shirafuchi.  <br>
- Marcos Suda.<br> <br>
2. Criando uma api para lista de tarefas <br>
Crie uma API para o gerenciamento de uma lista de tarefas pessoal, como por exemplo: <br>
● Estudar para prova de programação <br>
● Estudar para a prova de matemática <br>
● Ligar para meu amigo e perguntar quando devo entregar o trabalho <br>
É uma lista de afazeres. <br> <br>
As tarefas serão representadas por uma classe chamada Tarefa e deve possuir os seguintes atributos: <br>
● Id (int) <br>
● Descricao (string) <br>
● DataCriacao (DateTime) <br>
● Responsavel (string) <br>
● Concluida (bool) <br> <br>
Deverá ser criada uma classe Controller, para que a api receba as requisições de manipulação das tarefas. A controller deverá possuir métodos para: <br>
● Consultar todas as tarefas <br>
● Consultar todas as tarefas concluídas <br>
● Consultar todas as tarefas em aberto <br>
● Incluir uma nova tarefa <br>
● Atualizar a descrição de uma tarefa <br>
● Excluir uma tarefa <br> <br>
Atenção: <br>
● Todas as tarefas deverão ser armazenadas em um banco de dados SQlite. <br>
Consequentemente, todas as manipulações das tarefas serão feitas com o banco; <br>
● Coloque DataAnnotation na classe Model, para representar de maneira correta o nome da tabela e suas colunas no banco de dados; <br>
● Separe os métodos de manipulação do banco de dados em classes do sufixo “Repository”; <br>
● Teste todos os métodos no Postman; <br>
● A utilização do Swagger é opcional <br>
