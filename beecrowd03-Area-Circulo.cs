using ExemplosExplorando.Models;


using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o valor do raio
        double raio = Convert.ToDouble(Console.ReadLine());

        // Calcula a área da circunferência
        double pi = 3.14159;
        double area = pi * raio * raio;

        // Exibe o resultado com 4 casas decimais
        Console.WriteLine($"A={area:F4}");
    }
}

























