using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de horas do curso:");
        if (!int.TryParse(Console.ReadLine(), out int numeroHoras))
        {
            Console.WriteLine("Número de horas inválido.");
            return;
        }

        Console.WriteLine("Digite a data de início do curso (no formato dd/mm/aaaa):");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataInicio))
        {
            Console.WriteLine("Data de início inválida. Certifique-se de usar o formato correto (dd/mm/aaaa).");
            return;
        }

        Console.WriteLine("Digite a data de término do curso (no formato dd/mm/aaaa):");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataTermino))
        {
            Console.WriteLine("Data de término inválida. Certifique-se de usar o formato correto (dd/mm/aaaa).");
            return;
        }

        TimeSpan diferenca = dataTermino - dataInicio;
        int numeroDias = diferenca.Days;

        if (numeroDias <= 0)
        {
            Console.WriteLine("A data de término deve ser posterior à data de início.");
            return;
        }

        double resultado = (double)numeroHoras / numeroDias;

        Console.WriteLine($"Porcentagem a ser estudada por dia: {resultado:F2}%");
    }
}
