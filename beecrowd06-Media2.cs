using ExemplosExplorando.Models;


using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê as três notas
        double notaA = Convert.ToDouble(Console.ReadLine());
        double notaB = Convert.ToDouble(Console.ReadLine());
        double notaC = Convert.ToDouble(Console.ReadLine());

        // Define os pesos das notas
        double pesoA = 2.0;
        double pesoB = 3.0;
        double pesoC = 5.0;

        // Calcula a média ponderada
        double media = (notaA * pesoA + notaB * pesoB + notaC * pesoC) / (pesoA + pesoB + pesoC);

        // Exibe o resultado formatado
        Console.WriteLine($"MEDIA = {media:F1}");
    }
}

























