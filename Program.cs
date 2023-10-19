using ExemplosExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas-colecao.json");

List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

foreach (Vendas venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                    $"Preço {venda.Preco}, Data {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}



























