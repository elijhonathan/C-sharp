using System.Reflection;
using ExemplosExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Eli", sobrenome: "Jhonathan");

Pessoa p2 = new Pessoa(nome: "Jhennifer", sobrenome: "Tille");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

