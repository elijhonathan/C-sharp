using ExemplosExplorando.Models;

(int ID, string Nome, string Sobrenome, decimal Nota) tupla = (1, "Eli", "Jhonathan", 9.5M);

ValueTuple<int, string, string, decimal>  tupla2 = (2, "Jhennifer", "Tilly", 10.0M);

var tupla3 = Tuple.Create(3, "Gwen", "Tilly", 8.9M);

Console.WriteLine($"ID: {tupla.ID}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Nota: {tupla.Nota}");

Console.WriteLine($"ID: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");
Console.WriteLine($"Nota: {tupla2.Item4}");

Console.WriteLine($"ID: {tupla3.Item1}");
Console.WriteLine($"Nome: {tupla3.Item2}");
Console.WriteLine($"Sobrenome: {tupla3.Item3}");
Console.WriteLine($"Nota: {tupla3.Item4}");
