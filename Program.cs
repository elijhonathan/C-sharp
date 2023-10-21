using ExemplosExplorando.Models;


using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê as duas notas
        double notaA = Convert.ToDouble(Console.ReadLine());
        double notaB = Convert.ToDouble(Console.ReadLine());

        // Define os pesos das notas
        double pesoA = 3.5;
        double pesoB = 7.5;

        // Calcula a média ponderada
        double media = (notaA * pesoA + notaB * pesoB) / (pesoA + pesoB);

        // Exibe o resultado formatado
        Console.WriteLine($"MEDIA = {media:F5}");
    }
}

























