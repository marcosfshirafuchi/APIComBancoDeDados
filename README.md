# APIComBancoDeDados<br>
Trabalho em grupo do curso C# do RDI: <br>  
Felipe Estevão  <br>
Giovanna Ney  <br>
José Alexandre  <br>
Lucas Iozzi  <br>
Kelly Costa <br> 
Marcos Shirafuchi  <br>
Marcos Suda<br>
2. Criando uma api para lista de tarefas
Crie uma API para o gerenciamento de uma lista de tarefas pessoal, como por exemplo:
● Estudar para prova de programação
● Estudar para a prova de matemática
● Ligar para meu amigo e perguntar quando devo entregar o trabalho
É uma lista de afazeres.
As tarefas serão representadas por uma classe chamada Tarefa e deve possuir os
seguintes atributos:
● Id (int)
● Descricao (string)
● DataCriacao (DateTime)
● Responsavel (string)
● Concluida (bool)
Deverá ser criada uma classe Controller, para que a api receba as requisições de
manipulação das tarefas. A controller deverá possuir métodos para:
● Consultar todas as tarefas
● Consultar todas as tarefas concluídas
● Consultar todas as tarefas em aberto
● Incluir uma nova tarefa
● Atualizar a descrição de uma tarefa
● Excluir uma tarefa
Atenção:
● Todas as tarefas deverão ser armazenadas em um banco de dados SQlite.
Consequentemente, todas as manipulações das tarefas serão feitas com o banco;
● Coloque DataAnnotation na classe Model, para representar de maneira correta o
nome da tabela e suas colunas no banco de dados;
● Separe os métodos de manipulação do banco de dados em classes do sufixo
“Repository”;
● Teste todos os métodos no Postman;
● A utilização do Swagger é opcional
