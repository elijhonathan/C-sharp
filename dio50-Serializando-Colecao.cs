using ExemplosExplorando.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material de escritorio", 25.50M, dataAtual);
Vendas v2 = new Vendas(2, "Licensa de software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas-colecao.json", serializado);

Console.WriteLine(serializado);
