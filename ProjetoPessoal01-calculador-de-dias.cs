using ExemplosExplorando.Models;

class Program
{
    static void Main(string[] args)
    {
        // Lê a data informada pelo usuário
        Console.Write("Informe a data no formato (dd/MM/yyyy): ");
        string dataInformada = Console.ReadLine();

        // Converte a data informada para o tipo DateTime
        if (DateTime.TryParseExact(dataInformada, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
        {
            // Obtém a data atual
            DateTime dataAtual = DateTime.Now;

            // Calcula a diferença em dias
            TimeSpan diferenca = data - dataAtual;

            // Calcula o resultado multiplicando a diferença em dias por 3.5
            double resultado = diferenca.TotalDays * 3.5;

            // Exibe o resultado
            Console.WriteLine($"A diferença em dias é: {diferenca.TotalDays:F2}");
            Console.WriteLine($"O resultado da multiplicação é: {resultado:F2}");
        }
        else
        {
            Console.WriteLine("Data informada em formato inválido.");
        }
    }
}
