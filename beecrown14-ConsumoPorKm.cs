using System;

class Program
{
    static void Main(string[] args)
    {
        int distanciaPercorrida = int.Parse(Console.ReadLine());
        double combustivelGasto = double.Parse(Console.ReadLine());

        double consumoMedio = distanciaPercorrida / combustivelGasto;

        Console.WriteLine($"{consumoMedio:F3} km/l");
    }
}
