using System.Linq.Expressions;
using Calculadora.Services;


CalculadoraImprementacao c = new CalculadoraImprementacao();


int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
