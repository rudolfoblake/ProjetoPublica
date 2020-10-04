<h2>Projeto Publica</h2>

<h3>Solução do Desafio:</h3>

Para elaboração do desafio, foram utilizados:<br>

-Banco de dados: SQL Server<br>
-BackEnd: Asp/Net, C#, Entity Framework<br>
-FrontEnd: Angular com bootstrap<br>

<h3>WEB API:</h3>

  1.Visão Geral: Os registros são cadastrados e buscados no banco de dados SQL Server, feito através de Migrations via api. 
  A Api é responsável por buscar e cadastrar as informações no banco de dados, também é responsável por efetuar o tratamento das informações recebidas. 
  As requisições da API foram testadas via Postman, verificando o retorno das mesmas.   
    
  2.Models/Jogo: A Classe Jogo é responsável pelas propriedades da tabela do Jogo.

  3.Controller/JogoController: O Controller do Jogo é responsável pelas funções HTTP que fazem as buscas e alterações no Banco de Dados.

  4.Context: Contém as classes do repositório com as funções de busca no DB. Utiliza uma interface.

<h3>FRONT END ANGULAR:</h3>

  1.Visão Geral: No Front End o usuário pode navegar na tabela do jogo e listar, cadastrar, atualizar e excluir as partidas. 
  O Front End foi desenvolvido utilizando Angular com bootstrap, ele utiliza componentes. Os componentes possuem a formatação HTML e as funções TypeScritpt.
  As funções utilizam seu respectivo serviço para se conectar a API.

  2.Models/Jogo: A Classe Jogo é responsável pelas propriedades da tabela do Jogo.

  3.Component/Jogo: Componente da tabela Jogo.

  4.Services/jogo.service: Serviço responsável pelas requisições a API.


 <h3>Execução da Aplicação</h3>

<h3>1.Para criação do banco de dados no SQL Server:</h3>

Caminho: ProjetoPublica/backend

Comandos:

dotnet ef migrations add NomeDaCriacao

dotnet ef database update



<h3>2.Para executar a aplicação devem-se utilizar os seguintes comandos:</h3>

Caminho Back-End: ProjetoPublica/backend

Comando: dotnet watch run

Caminho Front-End: ProjetoPublica/frontend

Comando: npm start



<h3>3.Navegação:</h3>

Via Chrome ou outro navegador 
Caminho: http://localhost:4200/

