# Todolist

## 🚀 Funcionalidades

### Requisitos funcionais:
- o usuário deve conseguir fazer login.
- o usuário deve conseguir criar projetos.
- o usuário deve conseguir criar tarefas.
- o usuário deve conseguir marcar tarefas como feitas.
- o usuário deve conseguir comentar tarefas.
- o usuário deve conseguir criar etiquetas para categorizar tarefas.
- o usuário deve conseguir definir prioridades em uma tarefa, de 1 à 4.
- o usuário deve conseguir definir um lembrete para a tarefa.
- o usuário deve receber um email de lembrete de uma tarefa quando chegar o horário cadastrado como lembrete da tarefa.
- o usuário deve conseguir criar subtarefas de uma tarefa.
- o usuário deve conseguir adicionar a descrição de uma tarefa.
- o usuário deve conseguir definir uma data de vencimento de uma tarefa.
- o usuário deve poder filtrar tarefas por prioridade.
- o usuário deve conseguir filtrar tarefas por etiqueta.

## Requisitos não-funcionais
- Os dados devem ser armazenados num banco de dados PostgreSQL usando o serviço [Supabase](https://supabase.com/).
- Ao fazer o login, o usuário deve receber um token JWT que será usado para autorização das suas operações.
- A listagem de tarefas de um usuário deve ser armazenada em cache.

## Regras de negócio
- Um usuário pode atualizar seu email, nome e senha.
- Um usuário não pode atualizar seu email para um que já esteja cadastrado.
- Um usuário não pode ver tarefas, projetos e comentários criados por outros usuários.
- O cache da listagem de tarefas de um usuário deve ser invalidado quando for criada uma nova tarefa para o usuário.
- O cache da listagem de tarefas de um usuário deve ser invalidado quando for feita a atualização de uma tarefa de um usuário.
- O Token JWT deve expirar a cada 4 horas, forçando o usuário a fazer o login novamente para conseguir um novo token.


