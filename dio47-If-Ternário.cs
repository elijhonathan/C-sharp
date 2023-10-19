using ExemplosExplorando.Models;

int numero = 21;
int numero2 = 20;
bool ehPar = false;

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par.");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}

//IF Ternário
ehPar = numero2 % 2 == 0;
Console.WriteLine($"O número {numero2} é " + (ehPar ? "par" : "ímpar"));



















