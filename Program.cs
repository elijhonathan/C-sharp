using ExemplosExplorando.Models;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivoxs/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}





















