using System;

class Program
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);
        
        int maiorAB = (a + b + Math.Abs(a - b)) / 2; // Calcula o maior entre a e b
        
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2; // Calcula o maior entre o maiorAB e c
        
        Console.WriteLine($"{maiorABC} eh o maior");
    }
}
