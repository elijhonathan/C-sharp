using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o número do funcionário
        int numeroFuncionario = Convert.ToInt32(Console.ReadLine());

        // Lê a quantidade de horas trabalhadas
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        // Lê o valor por hora
        double valorPorHora = Convert.ToDouble(Console.ReadLine());

        // Calcula o salário
        double salario = horasTrabalhadas * valorPorHora;

        // Exibe o número e o salário formatado
        Console.WriteLine($"NUMBER = {numeroFuncionario}");
        Console.WriteLine($"SALARY = U$ {salario:F2}");
    }
}
