using ExemplosExplorando.Models;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MS", "Mato Grosso do Sul");
estados.Add("PR", "Paraná");
estados.Add("MT", "Mato Grosso");

//foreach (KeyValuePair<string, string> item in estados)
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Add("SC", "Santa Catarina");
Console.WriteLine("Lista");
estados["PR"] = "Paraná - Alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("SP");
Console.WriteLine("Lista");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//string chave = "MS";
string chave = "BA";
Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}

else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}














