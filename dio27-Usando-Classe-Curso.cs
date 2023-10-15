using System.Reflection;
using ExemplosExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Eli";
p1.Sobrenome = "Jhonathan";

Pessoa p2 = new Pessoa();
p2.Nome = "Jheniffer";
p2.Sobrenome = "Tille";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
