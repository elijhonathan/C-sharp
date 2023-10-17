using ExemplosExplorando.Models;

try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    //string[] linhas = File.ReadAllLines("Arquivos/arquivoxxLeitura.txt");
    //string[] linhas = File.ReadAllLines("Arquivos/mundo/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta não encontrada {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}
