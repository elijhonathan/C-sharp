using C_.Models;


int soma = 0, numero = 0;


do
{
    Console.WriteLine("Digite um número para somar (Digite 0 para parar): ");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{numero} + {soma} = {numero + soma}");
    soma += numero;
    


} while(numero != 0);








