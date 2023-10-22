using System;

class Program
{
    static void Main(string[] args)
    {
        string nomeVendedor = Console.ReadLine();

        double salarioFixo = Convert.ToDouble(Console.ReadLine());

        double totalVendas = Convert.ToDouble(Console.ReadLine());

        double comissao = 0.15 * totalVendas;

        double totalReceber = salarioFixo + comissao;

        Console.WriteLine($"TOTAL = R$ {totalReceber:F2}");
    }
}
