using System;

class Program
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');

        double A = Convert.ToDouble(valores[0]);
        double B = Convert.ToDouble(valores[1]);
        double C = Convert.ToDouble(valores[2]);

        double triangulo = (A * C) / 2;
        double circulo = 3.14159 * C * C;
        double trapezio = ((A + B) * C) / 2;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
    }
}
