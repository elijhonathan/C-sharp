using ExemplosExplorando.Models;
using Newtonsoft.Json;

Vendas v1 = new Vendas(1, "Material de escritorio", 25.50M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
