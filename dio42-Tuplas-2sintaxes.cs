using ExemplosExplorando.Models;

(int, string, string, decimal) tupla = (1, "Eli", "Jhonathan", 9.5M);
ValueTuple<int, string, string, decimal>  tupla2 = (2, "Jhennifer", "Tilly", 10.0M);

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Nota: {tupla.Item4}");

Console.WriteLine($"ID: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");
Console.WriteLine($"Nota: {tupla2.Item4}");
