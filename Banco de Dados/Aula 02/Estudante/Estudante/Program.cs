using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;


using var context = new AlunoContext();

context.Database.EnsureCreated(); //ve se esta criada a tabela se  nao estiver ele cria
//Create - Adicionar dados ao Banco de dados
Aluno pessoa1 = new Aluno("Cesar", 123456,"Comandos");
context.Alunos.Add(pessoa1);
context.SaveChanges(); //passa para o banco de dados e salva

//Read - Exibir o dado
var pessoas = context.Alunos.FirstOrDefault(c => c.Id == 1);
pessoas.ExibirDados();

//Update
pessoas = context.Alunos.FirstOrDefault(c =>c.Id == 6);
pessoas.Curso = "Micro";
context.SaveChanges();

//Delete
pessoas = context.Alunos.FirstOrDefault(c => c.Id == 3);
context.Remove(pessoas);
context.SaveChanges();



