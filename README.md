# SistemaControleDeTarefas
Um desafio prático com nível de dificuldade para um desenvolvedor fullstack C# Jr

Desafio: Sistema de Controle de Tarefas
Descrição do Projeto
Você foi contratado para desenvolver um sistema simples de controle de tarefas. O sistema permitirá que usuários façam login, criem, visualizem, editem e excluam tarefas. Cada tarefa terá um status (pendente, em andamento, concluída).
Requisitos Funcionais
1.	Autenticação e Autorização:
o	Implementar login e registro de usuários usando Identity com autenticação por JWT.
2.	CRUD de Tarefas:
o	O usuário pode:
	Criar uma tarefa com título, descrição e status inicial.
	Listar todas as tarefas vinculadas à sua conta.
	Atualizar o título, descrição ou status de uma tarefa.
	Excluir uma tarefa.
3.	Filtros e Ordenação:
o	Permitir filtrar as tarefas por status.
o	Ordenar as tarefas por data de criação ou status.
4.	Validações:
o	O título deve ter no mínimo 5 e no máximo 100 caracteres.
o	A descrição é opcional, mas não pode exceder 500 caracteres.
5.	Frontend:
o	Criar uma interface simples com React.js ou Razor Pages, que consuma a API.
o	O frontend deve permitir:
	Registro e login do usuário.
	Visualização, criação, edição e exclusão de tarefas.
	Aplicação dos filtros e ordenação.
________________________________________
Requisitos Técnicos
1.	Backend:
o	Tecnologias: ASP.NET Core Web API com Entity Framework Core.
o	Banco de dados: SQL Server ou MySQL.

---Próximos passos do backend----------------
o	Aplicar DDD com camadas (Application, Domain, Infrastructure).
o	Criar testes unitários com xUnit e Fluent Assertions.
----------------------------------------------
3.	Frontend:
o	Tecnologias: React.js com consumo da API usando Axios.
o	Gerenciar estado com Context API ou um gerenciador simples.
o	Utilizar Bootstrap ou CSS Modules para o estilo.

5.	Extras (Diferencial):
o	Criar uma documentação da API com Swagger.
o	Implementar paginação na listagem de tarefas.
o	Criar um pipeline básico no GitHub Actions para rodar testes automatizados no backend.
________________________________________
Entrega Esperada
1.	Repositório no GitHub com:
o	Código fonte do backend e frontend.
o	Instruções claras de como rodar o projeto localmente.
o	Banco de dados inicializado via migrations.





