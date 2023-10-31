using System;

class Program
{
    static void Main(string[] args)
    {
        // Ler o raio da esfera do usuário
        double raio = double.Parse(Console.ReadLine());

        // Calcular o volume da esfera
        double pi = 3.14159;
        double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

        // Exibir o resultado com 3 casas decimais
        Console.WriteLine($"VOLUME = {volume:F3}");
    }
}
